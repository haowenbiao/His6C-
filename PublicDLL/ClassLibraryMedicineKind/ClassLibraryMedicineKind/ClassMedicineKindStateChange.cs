using ClassLibraryAbstractDataInformation;
using ClassLibraryPublicEnum;
using ClassLibraryXmlizedAttribute;

namespace ClassLibraryMedicineKind
{
    [XmlizedSqlstringIDClass(SqlStringIDEdit = 125, Path = @"/Record")]
    [XmlizedClass(XmlTemplate = @"<Record><ClassMedicineKindStateChange></ClassMedicineKindStateChange></Record>", DefaultPath = @"/Record/ClassMedicineKindStateChange")]
    public class ClassMedicineKindStateChange : ClassAbstractData
    {
        [XmlizedProperty]
        public EnumeMedicineKindStateType 药品状态类型 { get; set; }

        [XmlizedProperty]
        public EnumeMedicineKindState 药品状态 { get; set; }

        public override bool Check()
        {
            return true;
        }

        public override void Clear()
        {
            return;
        }
    }
}