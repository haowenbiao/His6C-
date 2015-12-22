using System;
using ClassLibraryAbstractFormDataListBase;
using ClassLibraryLoginInformation;

namespace MedicineStock.DataList
{
    public partial class FormDataListUseUseFpSpreadFromAbstract : FormAbstractDataListUseFpSpreadBase
    {
        public FormDataListUseUseFpSpreadFromAbstract()
        {
            InitializeComponent();
        }

        public FormDataListUseUseFpSpreadFromAbstract(ClassLoginInformation valLoginInformation)
            : base(valLoginInformation, 36, false)
        {
            InitializeComponent();
        } 

        protected override long IDOfSqlStringThatGetColumnsOfDataTable
        {
            get 
            {
                //(96)SELECT ID,进货单编号,药库名称,总金额,进货时间,进货会计期,供货单位,备注,操作员 FROM dbo.YKGL_进货记录表_View WHERE 1 > 2
                return 96L;
            }
        }

        protected override string KeyInTheConfigFile
        {
            get { return "MedicineStock"; }
        }

        protected override string LoadSqlString
        {
            get { throw new NotImplementedException(); }
        }
    }
}
