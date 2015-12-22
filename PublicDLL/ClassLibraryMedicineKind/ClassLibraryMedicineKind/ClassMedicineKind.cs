using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineKind
{
	/// <summary>
	/// 基本药品种类属性
	/// </summary>
	[XmlizedClass(XmlTemplate = @"<MedicineKindPropertiesBasis></MedicineKindPropertiesBasis>", DefaultPath = @"/MedicineKindPropertiesBasis")]
	public class MedicineKindPropertiesBasis : ClassAbstractDataBaseXmlized
	{
		//共14项

		[XmlizedProperty]
		public string 通用名称 { get; set; }

		[XmlizedProperty]
		public string 通用名称_拼音码 { get; set; }

		[XmlizedProperty]
		public string 商品名称 { get; set; }

		[XmlizedProperty]
		public string 商品名称_拼音码 { get; set; }

		[XmlizedProperty]
		public double 单价 { get; set; }

		[XmlizedProperty]
		public string 用法用量 { get; set; }

		[XmlizedProperty]
		public string 药品生产企业 { get; set; }

		[XmlizedProperty]
		public long YKGL_计量单位_ID { get; set; }

		[XmlizedProperty]
		public long P_计费类型_ID { get; set; }

		[XmlizedProperty]
		public bool 是否消耗品 { get; set; }

		[XmlizedProperty]
		public long YKGL_药品种类销售状态_ID { get; set; }

		[XmlizedProperty]
		public long YKGL_药品种类进货状态_ID { get; set; }

		/// <summary>
		/// 以月为计量单位
		/// </summary>
		[XmlizedProperty]
		public long 有效期 { get; set; }

		[XmlizedProperty]
		public string 备注 { get; set; }
	}

	/// <summary>
	/// 附加药品种类属性
	/// </summary>
	[XmlizedClass(XmlTemplate = @"<MedicineKindPropertiesAdditional></MedicineKindPropertiesAdditional>", DefaultPath = @"/MedicineKindPropertiesAdditional")]
	public class MedicineKindPropertiesAdditional : ClassAbstractDataBaseXmlized
	{
		//共18项

		[XmlizedProperty]
		public string 批准文号 { get; set; }

		[XmlizedProperty]
		public string 成份 { get; set; }

		[XmlizedProperty]
		public string 性状 { get; set; }

		[XmlizedProperty]
		public string 适应症 { get; set; }

		[XmlizedProperty]
		public string 规格 { get; set; }

		[XmlizedProperty]
		public string 不良反应 { get; set; }

		[XmlizedProperty]
		public string 禁忌 { get; set; }

		[XmlizedProperty]
		public string 注意事项 { get; set; }

		[XmlizedProperty]
		public string 孕妇及哺乳期妇女用药 { get; set; }

		[XmlizedProperty]
		public string 儿童用药 { get; set; }

		[XmlizedProperty]
		public string 老年用药 { get; set; }

		[XmlizedProperty]
		public string 药物相互作用 { get; set; }

		[XmlizedProperty]
		public string 药物过量 { get; set; }

		[XmlizedProperty]
		public string 药理毒理 { get; set; }

		[XmlizedProperty]
		public string 药代动力学 { get; set; }

		[XmlizedProperty]
		public string 贮藏 { get; set; }

		[XmlizedProperty]
		public string 包装 { get; set; }

		[XmlizedProperty]
		public string 执行标准 { get; set; }
	}

	[XmlizedSqlstringIDClass(SqlStringIDLoad = 126, SqlStringIDAdd = 128, SqlStringIDEdit = 127, SqlStringIDRemove = 129, Path = @"/Record")]
	[XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
	public class ClassMedicineKindProperties : ClassAbstractData
	{
		#region 定义属性

		private MedicineKindPropertiesBasis _PropertiesBasis = new MedicineKindPropertiesBasis { 有效期 = 24 };

		[XmlizedProperty]
		public MedicineKindPropertiesBasis MedicineKindPropertiesBasis
		{
			get
			{
				return _PropertiesBasis;
			}
		}

		private MedicineKindPropertiesAdditional _PropertiesAdditional = new MedicineKindPropertiesAdditional();

		[XmlizedProperty]
		public MedicineKindPropertiesAdditional MedicineKindPropertiesAdditional
		{
			get
			{
				return _PropertiesAdditional;
			}
		}

		#endregion

		public override bool Check()
		{
			if (string.IsNullOrEmpty(MedicineKindPropertiesBasis.通用名称))
			{
				OnError(new EventArgsOfExecuteError("药品通用名称不能为空，请输入药品的通用名称！", "未通过数据合法性检查！"));
				return false;
			}

			if (string.IsNullOrEmpty(MedicineKindPropertiesBasis.通用名称_拼音码))
			{
                OnError(new EventArgsOfExecuteError("药品通用名称拼音码不能为空，请输入药品的通用名称拼音码！", "未通过数据合法性检查！"));
				return false;
			}

			if (string.IsNullOrEmpty(MedicineKindPropertiesBasis.商品名称))
			{
                OnError(new EventArgsOfExecuteError("药品商品名称不能为空，请输入药品的商品名称！", "未通过数据合法性检查！"));
				return false;
			}

			if (string.IsNullOrEmpty(MedicineKindPropertiesBasis.商品名称_拼音码))
			{
                OnError(new EventArgsOfExecuteError("药品商品名称拼音码不能为空，请输入药品的商品名称拼音码！", "未通过数据合法性检查！"));
				return false;
			}

			if (MedicineKindPropertiesBasis.YKGL_计量单位_ID < 1)
			{
                OnError(new EventArgsOfExecuteError("请设置计量单位！", "未通过数据合法性检查！"));
				return false;
			}

			if (MedicineKindPropertiesBasis.P_计费类型_ID < 1)
			{
                OnError(new EventArgsOfExecuteError("请设置计费类型！", "未通过数据合法性检查！"));
				return false;
			}

			return true;
		}

		public override void Clear()
		{
			_PropertiesBasis.通用名称 = null;
			_PropertiesBasis.通用名称_拼音码 = null;
			_PropertiesBasis.商品名称 = null;
			_PropertiesBasis.商品名称_拼音码 = null;
			_PropertiesBasis.用法用量 = null;
			_PropertiesBasis.药品生产企业 = null;
		}
	}

	[XmlizedSqlstringIDClass(SqlStringIDLoad = 124, Path = @"/Record")]
	[XmlizedClass(XmlTemplate = @"<Record><MedicineKindProperties></MedicineKindProperties></Record>", DefaultPath = @"/Record/MedicineKindProperties")]
	public class ClassMedicineKindPropertiesSimple : ClassAbstractData
	{
		[XmlizedProperty]
		public string 通用名称 { get; set; }

		[XmlizedProperty]
		public string 商品名称 { get; set; }
		
		[XmlizedProperty]
		public string 计量单位 { get; set;}

		[XmlizedProperty]
		public decimal 单价 { get; set; }

		public override bool Check()
		{
			return true;
		}

		public override void Clear()
		{
			return;
		}
	}

    [XmlizedClass(XmlTemplate = @"<MedicineKindPropertiesBasis></MedicineKindPropertiesBasis>", DefaultPath = @"/MedicineKindPropertiesBasis")]
    public class MedicineKindPropertiesBasisFull : ClassAbstractDataBaseXmlized
    {
        //共14项

        [XmlizedProperty]
        public string 通用名称 { get; set; }

        [XmlizedProperty]
        public string 通用名称_拼音码 { get; set; }

        [XmlizedProperty]
        public string 商品名称 { get; set; }

        [XmlizedProperty]
        public string 商品名称_拼音码 { get; set; }

        [XmlizedProperty]
        public double 单价 { get; set; }

        [XmlizedProperty]
        public string 用法用量 { get; set; }

        [XmlizedProperty]
        public string 药品生产企业 { get; set; }

        [XmlizedProperty]
        public string 计量单位 { get; set; }

        [XmlizedProperty]
        public string 计费类型 { get; set; }

        [XmlizedProperty]
        public bool 是否消耗品 { get; set; }

        [XmlizedProperty]
        public string 药品种类销售状态 { get; set; }

        [XmlizedProperty]
        public string 药品种类进货状态 { get; set; }

        /// <summary>
        /// 以月为计量单位
        /// </summary>
        [XmlizedProperty]
        public long 有效期 { get; set; }

        [XmlizedProperty]
        public string 备注 { get; set; }
    }

    [XmlizedSqlstringIDClass(SqlStringIDLoad = 141, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassMedicineKindPropertiesFull : ClassAbstractData
    {
        #region 定义属性

        private MedicineKindPropertiesBasisFull _PropertiesBasis = new MedicineKindPropertiesBasisFull { 有效期 = 24 };

        [XmlizedProperty]
        public MedicineKindPropertiesBasisFull MedicineKindPropertiesBasis
        {
            get
            {
                return _PropertiesBasis;
            }
        }

        private MedicineKindPropertiesAdditional _PropertiesAdditional = new MedicineKindPropertiesAdditional();

        [XmlizedProperty]
        public MedicineKindPropertiesAdditional MedicineKindPropertiesAdditional
        {
            get
            {
                return _PropertiesAdditional;
            }
        }

        #endregion

        public override bool Check()
        {
            return false;
        }

        public override void Clear()
        {
            return;
        }
    }

}
