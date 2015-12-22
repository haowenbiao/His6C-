using System;
using ClassLibraryAbstractDataInformation;
using ClassLibraryLoginInformation;

namespace ClassLibraryFormSaveBase
{
	public partial class FormSaveGeneric<TAbstractData> : FormSave where TAbstractData : ClassAbstractData, new()
	{
		#region 构造器

		/// <summary>
		/// 默认构造器
		/// </summary>
		public FormSaveGeneric()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 增加，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
		/// </summary>
		/// <param name="valLoginInformation">登录信息</param>
		/// <param name="valAuthorityId">需要的权限ID</param>
		public FormSaveGeneric(ClassLoginInformation valLoginInformation, long valAuthorityId)
			: base(valLoginInformation, valAuthorityId)
		{
			InitializeComponent();
			
			FormExecuteType=EnumFormExecuteType.Add;

			TAbstractData tmpData = new TAbstractData { P_操作员_ID = valLoginInformation.OperaterID };
			Data = tmpData;
		}

		/// <summary>
		/// 修改，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
		/// </summary>
		/// <param name="valLoginInformation">登录信息</param>
		/// <param name="valAuthorityId">需要的权限ID</param>
		/// <param name="valID"></param>
		public FormSaveGeneric(ClassLoginInformation valLoginInformation, long valAuthorityId, long valID)
			: base(valLoginInformation, valAuthorityId)
		{
			InitializeComponent();
			
			FormExecuteType=EnumFormExecuteType.Edit;

			TAbstractData tmpData = new TAbstractData {P_操作员_ID = valLoginInformation.OperaterID, ID = valID};
			Data = tmpData;
		}

		protected virtual void LoadData()
		{
			ClassDataLoader dataLoader = new ClassDataLoader {LoginInformation = LoginInformation, Data = Data};
			dataLoader.ExecuteError += OnLoadError;
			if (dataLoader.execute())
			{
				Data = Data;
			}
		}

		#endregion
		/// <summary>
		/// 设置执行类型，增加 还是 修改
		/// </summary>
		private EnumFormExecuteType FormExecuteType {get;set;}

		protected override void OnLoad(EventArgs e)
		{
			if (!DesignMode)
			{
				if (FormExecuteType==EnumFormExecuteType.Edit)
				{
					LoadData();
				}
				BindingData();
			}

			base.OnLoad(e);
		}
		
		private void Add()
		{
			ClassDataAdder dataAdder = new ClassDataAdder
			{
				AuthorityID = AuthorityID,
				LoginInformation = LoginInformation,
				Data = Data
			};
			dataAdder.ExecuteError += this_ExecuteError;
			dataAdder.ExecuteSucceed += this_ExecuteSucceed;
			dataAdder.execute();
            dataAdder.ExecuteError -= this_ExecuteError;
			dataAdder.ExecuteSucceed -= this_ExecuteSucceed;
		}

		private void Edit()
		{
			ClassDataEditer dataEditer=new ClassDataEditer
			{
				AuthorityID = AuthorityID,
				LoginInformation = LoginInformation,
				Data = Data
			};
            dataEditer.ExecuteError += this_ExecuteError;
			dataEditer.ExecuteSucceed += this_ExecuteSucceed;
			dataEditer.execute();
            dataEditer.ExecuteError -= this_ExecuteError;
			dataEditer.ExecuteSucceed -= this_ExecuteSucceed;
		}

		protected virtual void buttonOK_Add_Click(object sender, EventArgs e)
		{
			Add();
		}

		protected virtual void buttonOK_Edit_Click(object sender, EventArgs e)
		{
			Edit();
		}
	}

    internal enum EnumFormExecuteType
	{
		Add=1,
		Edit=2,
	}
}
