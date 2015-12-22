using System;
using ClassLibraryAbstractDataInformation;
using ClassLibraryEventArgs.EventArgsOfRecord;
using ClassLibraryLoginInformation;

namespace CustomForm
{
    public abstract partial class FormCustomListItemAdd<TAbstractData> : FormCustomListItemAdd_Design where TAbstractData : ClassAbstractDataBaseXmlized, new()
    {
        #region 构造器

        protected FormCustomListItemAdd()
        {
            InitializeComponent();
        }

        protected FormCustomListItemAdd(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation)
        {
            InitializeComponent();
            ListItem = new TAbstractData();
            bindingSourceListItem.DataSource = ListItem;
            
            buttonOK.Click += buttonOK_Click;
        }

        #endregion

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode)
            {
                BindingData();
            }
            base.OnLoad(e);
        }

        #region 自定义事件

        public event EventHandler<EventArgsOfRecordDetail> ListItemAdded;

        protected void OnListItemAdded(EventArgsOfRecordDetail e)
        {
            EventHandler<EventArgsOfRecordDetail> Add = ListItemAdded;
            if (Add != null) Add(this, e);
        }

        #endregion

        #region 数据

        protected TAbstractData ListItem { get; set; }

        public abstract void BindingData();

        #endregion

        protected abstract void buttonOK_Click(object sender, EventArgs e);

    }
}
