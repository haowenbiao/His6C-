using System;
using System.Collections;
using System.Reflection;
using System.Xml;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;
using ClassLibraryPublicEnum;
using ClassLibrarySQLExecute;
using ClassLibraryXmlizedAttribute;


namespace ClassLibraryAbstractDataInformation
{
	public abstract class ClassAbstractDataFoundation
	{
		
	}

	public abstract class ClassAbstractDataBaseXmlized : ClassAbstractDataFoundation, IImportFromXmlable, IExportToXmlable
	{
		/// <summary>
		/// 从XML中加载数据
		/// </summary>
		/// <returns></returns>
		public string ExportToXml()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode DefaulParent = null;
			Type type = GetType();

			#region 生成根节点或父节点和SqlStringID节点

			object[] tmpCustomAttributes = type.GetCustomAttributes(true);
			XmlizedClassAttribute classAttribute =
				GetAttribute(tmpCustomAttributes, a => a.GetType() == typeof(XmlizedClassAttribute)) as
				XmlizedClassAttribute;

			if (classAttribute != null)
			{
				xmlDocument.LoadXml(classAttribute.XmlTemplate);
				DefaulParent = xmlDocument.SelectSingleNode(classAttribute.DefaultPath);

				#region XmlizedSqlstringIDClassAttribute属性

				XmlizedSqlstringIDClassAttribute sqlstringIDClassAttribute =
					GetAttribute(tmpCustomAttributes, a => a.GetType() == typeof(XmlizedSqlstringIDClassAttribute)) as
					XmlizedSqlstringIDClassAttribute;
				if (sqlstringIDClassAttribute != null)
				{
					string tmpSqlStringIDXml = sqlstringIDClassAttribute.ToXml();
					XmlDocument tmpXmlDocument = new XmlDocument();
					tmpXmlDocument.LoadXml(tmpSqlStringIDXml);
					XmlElement tmpRoot = tmpXmlDocument.DocumentElement;
					if (tmpRoot != null)
					{
						XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpRoot, true);
						if (string.IsNullOrEmpty(sqlstringIDClassAttribute.Path))
						{
							DefaulParent.AppendChild(tmpXmlNode);
						}
						else
						{
							XmlNode tmpParentxmlNode = xmlDocument.SelectSingleNode(sqlstringIDClassAttribute.Path);
							tmpParentxmlNode.AppendChild(tmpXmlNode);
						}
					}
				}

				#endregion

				#region XmlizedAuthorityIDClassAttribute属性

				//XmlizedAuthorityIDClassAttribute authorityIdClassAttribute =
				//    GetAttribute(tmpCustomAttributes, a => a.GetType() == typeof(XmlizedAuthorityIDClassAttribute)) as
				//    XmlizedAuthorityIDClassAttribute;
				
				//if (authorityIdClassAttribute != null)
				//{
				//    ClassAbstractData data = this as ClassAbstractData;
				//    if (data !=null )
				//    {
				//        authorityIdClassAttribute.P_操作员_ID = data.P_操作员_ID;
				//    }
				//    string tmpSqlStringIDXml = authorityIdClassAttribute.ToXml();
				//    XmlDocument tmpXmlDocument = new XmlDocument();
				//    tmpXmlDocument.LoadXml(tmpSqlStringIDXml);
				//    XmlElement tmpRoot = tmpXmlDocument.DocumentElement;
				//    if (tmpRoot != null)
				//    {
				//        XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpRoot, true);
				//        if (string.IsNullOrEmpty(authorityIdClassAttribute.Path))
				//        {
				//            DefaulParent.AppendChild(tmpXmlNode);
				//        }
				//        else
				//        {
				//            XmlNode tmpParentxmlNode = xmlDocument.SelectSingleNode(authorityIdClassAttribute.Path);
				//            tmpParentxmlNode.AppendChild(tmpXmlNode);
				//        }
				//    }
				//}

				#endregion
			}

			#endregion

			#region 生成子节点
			if (DefaulParent == null)
			{
				return null;
			}
			XmlizedPropertyAttribute propertyAttribute;
			foreach (PropertyInfo propertyInfo in type.GetProperties())
			{

				foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
				{
					propertyAttribute = attribute as XmlizedPropertyAttribute;
					if (propertyAttribute != null)
					{
						XmlNode tmpParent = string.IsNullOrEmpty(propertyAttribute.Path) ? DefaulParent : xmlDocument.SelectSingleNode(propertyAttribute.Path);
						//继承了IExportToXmlable接口的属性
						if (propertyInfo.PropertyType.GetInterface("IExportToXmlable", true) == typeof(IExportToXmlable))
						{
							IExportToXmlable exportToXmlable = propertyInfo.GetValue(this, null) as IExportToXmlable;
							if (exportToXmlable != null)
							{
								XmlDocument tmpXmlDocument = new XmlDocument();
								tmpXmlDocument.LoadXml(exportToXmlable.ExportToXml());
								if (tmpXmlDocument.DocumentElement != null)
								{
									XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpXmlDocument.DocumentElement, true);
									tmpParent.AppendChild(tmpXmlNode);
								}
							}
						}
						else
						{
							//继承了List<IExportToXmlable>的属性
							if (propertyInfo.PropertyType.IsGenericType)
							{
								if (propertyInfo.PropertyType.GetGenericArguments()[0].GetInterface("IExportToXmlable") == typeof(IExportToXmlable))
								{
									IList exportToXmlables =
										propertyInfo.GetValue(this, null) as IList;
									if (exportToXmlables != null)
									{
										string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName) ? propertyInfo.Name : propertyAttribute.ElementName;
										XmlElement tmpXmlElement = xmlDocument.CreateElement(tmpElementName);
										foreach (IExportToXmlable exportToXmlable in exportToXmlables)
										{
											XmlDocument tmpXmlDocument = new XmlDocument();
											tmpXmlDocument.LoadXml(exportToXmlable.ExportToXml());
											XmlElement tmpRoot = tmpXmlDocument.DocumentElement;
											if (tmpRoot != null)
											{
												XmlNode tmpXmlNode = xmlDocument.ImportNode(tmpRoot, true);
												tmpXmlElement.AppendChild(tmpXmlNode);
											}
										}
										tmpParent.AppendChild(tmpXmlElement);
									}
								}
							}
							//普通值类型属性
							else
							{
								string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName)
															? propertyInfo.Name
															: propertyAttribute.ElementName;
								XmlElement tmpXmlElement = xmlDocument.CreateElement(tmpElementName);
								object tmpValue = propertyInfo.GetValue(this, null);
								//枚举类型
								if (propertyInfo.PropertyType.IsEnum)
								{
									tmpXmlElement.InnerText = ((int)tmpValue).ToString();
								}
								else
								{
									if (propertyInfo.PropertyType == typeof(bool))
									{
										bool tmpBool = (bool) tmpValue;
										tmpXmlElement.InnerText = tmpBool ? "1" : "0";
									}
									else
									{
										tmpXmlElement.InnerText = tmpValue == null ? "" : tmpValue.ToString();
									}
								}
								tmpParent.AppendChild(tmpXmlElement);
							}
						}

					}
				}
			}
			#endregion

				return xmlDocument.OuterXml;
		}

		/// <summary>
		/// 生成XML格式的数据
		/// </summary>
		/// <param name="valXml"></param>
		public void ImportFromXml(string valXml)
		{
			Type type = GetType();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(valXml);
			XmlizedClassAttribute classAttribute = GetAttribute(type.GetCustomAttributes(true), a => a.GetType() == typeof(XmlizedClassAttribute)) as XmlizedClassAttribute;
			if (classAttribute == null)
			{
				return;
			}
			string DefaultPath = classAttribute.DefaultPath;

			foreach (PropertyInfo propertyInfo in type.GetProperties())
			{
				XmlizedPropertyAttribute propertyAttribute;
				foreach (Attribute attribute in propertyInfo.GetCustomAttributes(true))
				{
					propertyAttribute = attribute as XmlizedPropertyAttribute;
					if (propertyAttribute != null)
					{
						string tmpElementName = string.IsNullOrEmpty(propertyAttribute.ElementName)
													? propertyInfo.Name
													: propertyAttribute.ElementName;
						string tmpElementPath = string.IsNullOrEmpty(propertyAttribute.Path)
													? DefaultPath + @"/" + tmpElementName
													: propertyAttribute.Path + @"/" + tmpElementName;
						XmlNode tmpParentXmlNode = xmlDocument.SelectSingleNode(tmpElementPath);
						//继承了IExportToXmlable接口的属性
						if (propertyInfo.PropertyType.GetInterface("IExportToXmlable", true) == typeof(IExportToXmlable))
						{
							IImportFromXmlable importFromXmlable =
								propertyInfo.GetValue(this, null) as IImportFromXmlable;
							if (importFromXmlable != null) importFromXmlable.ImportFromXml(tmpParentXmlNode.OuterXml);
						}
						else
						{
							//继承了List<IImportFromXmlable>的属性
							if (propertyInfo.PropertyType.IsGenericType)
							{
								Type tmpType = propertyInfo.PropertyType.GetGenericArguments()[0];
								IImportFromXmlable tmpImportFromXmlableInstance;
								if (tmpType.GetInterface("IImportFromXmlable") == typeof(IImportFromXmlable))
								{
									IList importFromXmlables = propertyInfo.GetValue(this, null) as IList;
									Assembly assembly = Assembly.GetAssembly(tmpType);
									foreach (XmlNode tmpChildNode in tmpParentXmlNode.ChildNodes)
									{
										tmpImportFromXmlableInstance =
											assembly.CreateInstance(tmpType.FullName) as IImportFromXmlable;
										if (tmpImportFromXmlableInstance != null)
										{
											tmpImportFromXmlableInstance.ImportFromXml(tmpChildNode.OuterXml);
											if (importFromXmlables != null)
											{
												importFromXmlables.Add(tmpImportFromXmlableInstance);
											}
										}
									}
								}
							}
							
							else
							{
								//枚举类型
								if (propertyInfo.PropertyType.IsEnum)
								{
									if (Enum.IsDefined(propertyInfo.PropertyType, Convert.ToInt32(tmpParentXmlNode.InnerXml)))
									{
										object tmpValue = Enum.Parse(propertyInfo.PropertyType, tmpParentXmlNode.InnerXml);
										propertyInfo.SetValue(this, tmpValue, null);
									}
								}
								//普通值类型属性
								else
								{
									//bool型
									if (propertyInfo.PropertyType == typeof(bool))
									{
										propertyInfo.SetValue(this, tmpParentXmlNode.InnerText != "0", null);
									}
									else
									{
										object tmpValue = Convert.ChangeType(tmpParentXmlNode.InnerText,
																			 propertyInfo.PropertyType);
										propertyInfo.SetValue(this, tmpValue, null);
									}
								}
							}
						}
					}
				}
			}
		}

		private Attribute GetAttribute(object[] valAttibutes, Predicate<Attribute> valPredicate)
		{
			foreach (Attribute valAttibute in valAttibutes)
			{
				if (valPredicate(valAttibute))
				{
					return valAttibute;
				}
			}
			return null;
		}
	}

	public abstract class ClassAbstractDataBase : ClassAbstractDataBaseXmlized
	{
		[XmlizedProperty]
		public long ID{get;set;}

		[XmlizedProperty]
		public long P_操作员_ID { get; set; }
	}

	public abstract class ClassAbstractData : ClassAbstractDataBase
	{
		#region 方法

		/// <summary>
		/// 验证数据的合法性
		/// </summary>
		/// <returns></returns>
		public abstract bool Check();

		/// <summary>
		/// 清除所有数据
		/// </summary>
		public abstract void Clear();

		#endregion

		#region 自定义事件

		public event ExecuteErrorHandler Error;

		protected virtual void OnError(EventArgsOfExecuteError e)
		{
			if (Error != null)
			{
				Error(this, e);
			}
		}

		//protected void this_Error(object sender, EventArgsOfError e)
		//{
		//    OnError(e);
		//}

		#endregion
	}

	public abstract class ClassAbstractDataExecute
	{

		#region 事件

        public event ExecuteErrorHandler ExecuteError;

        protected void this_ExecuteError(object sender, EventArgsOfExecuteError e)
		{
			OnExecuteError(e);
		}

        public event ExecuteSucceedHandler ExecuteSucceed;

		protected void this_ExecuteSucceed(object sender, EventArgsOfExecuteSucceed e)
		{
			OnExecuteSucceed(e);
		}

        protected virtual void OnExecuteError(EventArgsOfExecuteError e)
		{
			if (ExecuteError != null)
			{
				ExecuteError(this, e);
			}
		}

		protected virtual void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
		{
			if (ExecuteSucceed != null)
			{
				ExecuteSucceed(this, e);
			}
		}

		#endregion

		#region 权限验证

		/// <summary>
		/// 权限级别
		/// </summary>
		public EnumAuthorityLevel AuthorityLevel { get; set; }

		/// <summary>
		/// 权限编号
		/// </summary>
		public long AuthorityID { get; set; }

		/// <summary>
		/// 操作员登录信息
		/// </summary>
		public ClassLoginInformation LoginInformation { get; set; }

		/// <summary>
		/// 验证权限
		/// </summary>
		/// <returns></returns>
		protected abstract bool AuthorityVerify();

		#endregion

		public abstract bool execute();

	}

	public abstract class ClassAbstractDataExcuteWithDataInformation : ClassAbstractDataExecute 
	{

		/// <summary>
		/// 验证权限
		/// </summary>
		/// <returns></returns>
		protected sealed override bool AuthorityVerify()
		{
		    ClassAuthorityVerification AuthorityVerification = new ClassAuthorityVerification(LoginInformation, AuthorityID,
		                                                                                      Data);
		    bool tmpSucceed = AuthorityVerification.VerifyAuthority();

		    return tmpSucceed;
		}

    //if (LoginInformation.OperaterID == 1)
    //        {
    //            return true;
    //        }

    //        bool tmpIsSuperAuthority = ClassAuthoritySetPublic.GetIsSuperAuhority(LoginInformation.ConnectionString,
    //                                                                              AuthorityID);

    //        switch (AuthorityLevel)
    //        {
    //            case EnumAuthorityLevel.任何操作员:
    //                return true;
    //            case EnumAuthorityLevel.有权限的操作员:
    //                if (tmpIsSuperAuthority && LoginInformation.OperaterID != 1)
    //                {
    //                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "只有超级用户才有进行此操作的权限"));
    //                    return false;
    //                }
    //                if (!ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, AuthorityID))
    //                {
    //                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "当前操作员没有进行此操作的权限"));
    //                    return false;
    //                }
    //                break;
    //            case EnumAuthorityLevel.有权限且创建该记录的操作员:
    //                if (tmpIsSuperAuthority && LoginInformation.OperaterID != 1)
    //                {
    //                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "只有超级用户才有进行此操作的权限"));
    //                    return false;
    //                }
    //                if (!ClassAuthoritySetPublic.VerifyAuthority(LoginInformation, AuthorityID))
    //                {
    //                    OnExecuteError(new EventArgsOfExecuteError("权限验证错误：", "当前操作员没有进行此操作的权限"));
    //                    return false;
    //                }

    //                ClassDataLoader dataLoader = new ClassDataLoader(LoginInformation, Data);
    //                bool loadSucceed = dataLoader.execute();
    //                if (loadSucceed)
    //                {
    //                    if (LoginInformation.OperaterID != Data.P_操作员_ID)
    //                    {
    //                        OnExecuteError(new EventArgsOfExecuteError("只有建立该记录的操作员才能进行此操作。", "权限不足！"));
    //                        return false;
    //                    }
    //                }
    //                else
    //                {
    //                    OnExecuteError(new EventArgsOfExecuteError("权限验证过程中，未能正确加载数据！", "错误！"));
    //                    return false;
    //                }
    //                break;
    //        }
    //        return true;
    //    }

		/// <summary>
		/// 验证数据
		/// </summary>
		/// <returns></returns>
		protected virtual bool DataVerify()
		{
			if (Data == null)
			{
                OnExecuteError(new EventArgsOfExecuteError("已知错误！", "未能正确初始化Data！"));
				return false;
			}
			if (!Data.Check())
			{
                //OnError(this, new EventArgsOfError("已知错误！", "数据未通过合法性检查！"));已在Data.Check()中调用
				return false;
			}

			return true;
		}

		private ClassAbstractData _data;

		public ClassAbstractData Data
		{
			get
			{
				return _data;
			}
			set
			{
				if (_data != null)
				{
					_data.Error -= this_ExecuteError;
				}
				_data = value;
				if (value != null)
				{
					_data.Error += this_ExecuteError;
				}
			}
		}

	}

	/// <summary>
	/// 任何操作员都可进行此操作。
	/// </summary>
	public class ClassDataLoader : ClassAbstractDataExcuteWithDataInformation
	{

		public ClassDataLoader()
			: this(null,null)
		{
			AuthorityLevel = EnumAuthorityLevel.任何操作员;
			AuthorityID = 0;
		}
		
		public ClassDataLoader(ClassLoginInformation valLoginInformation,ClassAbstractData valData)
		{
			AuthorityLevel = EnumAuthorityLevel.任何操作员;
			LoginInformation = valLoginInformation;
			AuthorityID = 0;
			Data = valData;
		}

		public override bool execute()
		{
			string tmpXmlParemeterString = Data.ExportToXml();
			ClassExecuteWithXmlParameterString a = new ClassExecuteWithXmlParameterString(LoginInformation, "usp_LoadGeneral", tmpXmlParemeterString);
			a.Error += this_ExecuteError;
			a.ExecuteSucceed += this_ExecuteSucceed;
		    bool suceed = a.execute();
            a.ExecuteSucceed -= this_ExecuteSucceed;
            a.Error -= this_ExecuteError;
		    return suceed;
		}

		protected override void OnExecuteSucceed(EventArgsOfExecuteSucceed e)
		{
			Data.ImportFromXml(e.AdditionalInformation as string);
			base.OnExecuteSucceed(e);
		}

	}

	public class ClassDataEditer : ClassAbstractDataExcuteWithDataInformation
	{
		/// <summary>
		/// 默认权限是“有权限且创建该记录的操作员”
		/// </summary>
		public ClassDataEditer()
			: this(null, null, 0)
		{
			AuthorityLevel = EnumAuthorityLevel.有权限且创建该记录的操作员;
		}

		public ClassDataEditer(ClassLoginInformation valLoginInformation, ClassAbstractData valData,long valAuthorityID)
		{
			AuthorityLevel = EnumAuthorityLevel.有权限的操作员;
			LoginInformation = valLoginInformation;
			Data = valData;
			AuthorityID = valAuthorityID;
		}

		public override bool execute()
		{
			//验证权限
			if (!AuthorityVerify())
			{
				return false;
			}
			//验证数据
			if (!DataVerify())
			{
				return false;
			}
			Data.P_操作员_ID = LoginInformation.OperaterID;
			string tmpXmlParemeterString = Data.ExportToXml();
			ClassExecuteWithXmlParameterString a = new ClassExecuteWithXmlParameterString(LoginInformation, "usp_EditGeneral", tmpXmlParemeterString);
            a.Error += this_ExecuteError;
            a.ExecuteSucceed += this_ExecuteSucceed;
            bool valExecuted = a.execute();
            a.ExecuteSucceed -= this_ExecuteSucceed;
            a.Error -= this_ExecuteError;
            return valExecuted;
		}
	}

	public class ClassDataAdder : ClassAbstractDataExcuteWithDataInformation
	{
		/// <summary>
		/// 默认权限是“有权限的操作员”
		/// </summary>
		public ClassDataAdder()
			: this(null, null, 0)
		{
			AuthorityLevel = EnumAuthorityLevel.有权限的操作员;
		}

		public ClassDataAdder(ClassLoginInformation valLoginInformation,ClassAbstractData valData,long valAuthorityID)
		{
			AuthorityLevel = EnumAuthorityLevel.有权限的操作员;
			LoginInformation = valLoginInformation;
			Data = valData;
			AuthorityID = valAuthorityID;
		}
		public override bool execute()
		{
			//验证权限
			if (!AuthorityVerify())
			{
				return false;
			}
			//验证数据
			if (!DataVerify())
			{
				return false;
			}

			string tmpXmlParemeterString = Data.ExportToXml();
			ClassExecuteWithXmlParameterString a = new ClassExecuteWithXmlParameterString(LoginInformation, "usp_AddGeneral", tmpXmlParemeterString);
			a.Error += this_ExecuteError;
			a.ExecuteSucceed += this_ExecuteSucceed;
		    bool valExecuted = a.execute();
            a.ExecuteSucceed -= this_ExecuteSucceed;
		    a.Error -= this_ExecuteError;
		    return valExecuted;
		}

	}

	public class ClassDataRemover<TAbstractData> : ClassAbstractDataExcuteWithDataInformation where TAbstractData : ClassAbstractData, new()
	{
		/// <summary>
		/// 默认权限是“有权限且创建该记录的操作员”
		/// </summary>
		public ClassDataRemover()
			: this(null, 0, 0)
		{
		   
		}

		public ClassDataRemover(ClassLoginInformation valLoginInformation, long valID, long valAuthorityID)
		{
			AuthorityLevel = EnumAuthorityLevel.有权限且创建该记录的操作员;
			LoginInformation = valLoginInformation;
			TAbstractData abstractData=new TAbstractData {ID = valID};
			Data = abstractData;
			AuthorityID = valAuthorityID;
		}
		public override bool execute()
		{
			//验证权限
			if (!AuthorityVerify())
			{
				return false;
			}

			Data.P_操作员_ID = LoginInformation.OperaterID;
			string tmpXmlParemeterString = Data.ExportToXml();
			ClassExecuteWithXmlParameterString a = new ClassExecuteWithXmlParameterString(LoginInformation, "usp_RemoveGeneral", tmpXmlParemeterString);
            a.Error += this_ExecuteError;
            a.ExecuteSucceed += this_ExecuteSucceed;
            bool valExecuted = a.execute();
            a.ExecuteSucceed -= this_ExecuteSucceed;
            a.Error -= this_ExecuteError;
            return valExecuted;
		}

	}
}
