using System;
using ClassLibraryAbstractDataInformation;
using ClassLibraryGetSQLString;
using ClassLibraryLoginInformation;
using ClassLibrarySQLExecute;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryAccountingPeriodInformation
{
    [XmlizedSqlstringIDClass(SqlStringIDLoad = 162, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><RecordInformations></RecordInformations></Record>", DefaultPath = @"/Record/RecordInformations")]
    public class ClassAccountingPeriodInformationProperties : ClassAbstractData
    {
        #region 属性

        private int _年份;
        [XmlizedProperty]
        public int 年份
        {
            get
            {
                return _年份;
            }
            set
            {
                _年份 = value;
                Make会计期String();
                Make会计期();
            }
        }

        private int _月份;
        [XmlizedProperty]
        public int 月份
        {
            get
            {
                return _月份;
            }
            set
            {
                _月份 = value;
                Make会计期String();
                Make会计期();
            }
        }

        private int _日份;
        [XmlizedProperty]
        public int 日份
        {
            get
            {
                return _日份;
            }
            set
            {
                _日份 = value;
                Make会计期String();
                Make会计期();
            }
        }

        private void Make会计期String()
        {
            会计期String = _年份 + "年" + _月份 + "月" + _日份 + "日";
        }

        private void Make会计期()
        {
            会计期 = _年份 * 10000 + _月份 * 100 + (_日份 < 0 ? Math.Abs(_日份) : _日份 + 31);
        }

        public string 会计期String { get; private set; }

        public int 会计期 { get; private set; }

        #endregion

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
        }

        public bool Load(string  valConnectionString)
        {
            ClassLoginInformation tmpLoginInformation = new ClassLoginInformation(valConnectionString, 1);
            ClassDataLoader loader = new ClassDataLoader(tmpLoginInformation, this);
            return loader.execute();
        }
    }

    public class ClassLibraryAccountingPeriodPublic
    {
        public static long GetCurrentAccountingPeriod(string valConnectionString)
        {
            //(98)SELECT dbo.get当前会计期() AS ID
            string tmpSQLString = ClassGetSQLString.GetSQLString(valConnectionString, 98);
            if (string.IsNullOrEmpty(tmpSQLString))
            {
                return 0;
            }
            long? tmpCurrentAccountingPeriod = ClassExecuteScalarData.GetScalarLong(valConnectionString, tmpSQLString);
            return tmpCurrentAccountingPeriod ?? 0L;
        }
    }
}
