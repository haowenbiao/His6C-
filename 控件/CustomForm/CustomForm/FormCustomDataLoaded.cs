using System;
using System.Windows.Forms;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfExecute;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public abstract partial class FormCustomDataLoaded<TAbstractData> : FormCustomDataLoaded_Design where TAbstractData : ClassAbstractData, new()
    {
        #region 构造器

        protected FormCustomDataLoaded()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 增加，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        protected FormCustomDataLoaded(ClassLoginInformation valLoginInformation, long valAuthorityID)
            : base(valLoginInformation,valAuthorityID)
        {
            InitializeComponent();

            FormExecuteType = EnumFormExecuteType.Add;

            TAbstractData tmpData = new TAbstractData { P_操作员_ID = valLoginInformation.OperaterID };
            Data = tmpData;
        }

        /// <summary>
        /// 修改，有权限的操作员和超级用户可以登录，如果AuthorityID小于等于0，则任何操作员都不可登录。
        /// </summary>
        /// <param name="valLoginInformation"></param>
        /// <param name="valAuthorityID"></param>
        /// <param name="valID"></param>
        protected FormCustomDataLoaded(ClassLoginInformation valLoginInformation, long valAuthorityID, long valID)
            : base(valLoginInformation, valAuthorityID)
        {
            InitializeComponent();

            FormExecuteType = EnumFormExecuteType.Edit;

            TAbstractData tmpData = new TAbstractData { P_操作员_ID = valLoginInformation.OperaterID, ID = valID };
            Data = tmpData;
        }

        #endregion

        #region 数据绑定

        protected abstract void BindingData();

        protected void ReBinding()
        {
            BindingManagerBase bmb = BindingContext[Data];
            bmb.ResumeBinding();
        }

        #endregion

        #region 加载数据

        protected virtual void LoadData()
		{
			ClassDataLoader dataLoader = new ClassDataLoader {LoginInformation = LoginInformation, Data = Data};
            dataLoader.ExecuteError += OnLoadError;
			if (dataLoader.execute())
			{
				Data = Data;
			}
            dataLoader.ExecuteError -= OnLoadError;
		}

        private enum EnumFormExecuteType
        {
            Add = 1,
            Edit = 2,
        }

		/// <summary>
		/// 设置执行类型，增加 还是 修改，如果是 查看 操作，则视为 修改
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

        /// <summary>
        /// 当在更改窗体中，加载错误时的委托方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnLoadError(object sender, EventArgsOfExecuteError e)
        {
            MessageBox.Show(e.CustomErrorMessage + "\n" + e.SystemErrorMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CanShow = false;
        }

        #endregion
        
    }
}
