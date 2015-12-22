namespace ClassLibraryPublicEnum
{
    public enum enum性别
    {
        男 = 0,
        女
    }

    public enum enum是否
    {
        否 = 0,
        是
    }

    /// <summary>
    /// 权限属性
    /// </summary>
    public enum EnumAuthorityLevel
    {
        任何操作员,
        有权限的操作员,
        有权限且创建该记录的操作员,
    }

    /// <summary>
    /// MedicineBatchControl查找类型。
    /// </summary>
    public enum EnumSearchType
    {
        OnlySearch,//只查找
        FirstSearchThanAdd,//先查找，如没有找到，则再增加
        FirstAddThanSearch//先增加，如增加失败，则在查找。
    }

    /// <summary>
    /// MedicineStoreHouseSelector加载药库信息类型
    /// </summary>
    public enum EnumLoadStoreHouseInformationType
    {
        All,//所有
        OnlyStoreHouse,//只库房
        OnlyDrugStore,//只药房
        AllWithAll,
        OnlyStoreHouseWithAll,
        OnlyDrugStoreWithAll
    }

    //DateSelectControl日期期间选择类型
    public enum EnumDatePeriodSelectType
    {
        本自然日,
        本自然月,
        自然期间,
        本会计日,
        本会计月,
        会计期间
    }


    /// <summary>
    /// 药品状态
    /// </summary>
    public enum EnumeMedicineKindState
    {
        正常 = 1,
        暂停 = 2
    }

    /// <summary>
    /// 药品状态类型
    /// </summary>
    public enum EnumeMedicineKindStateType
    {
        进货状态 = 1,
        销售状态 = 2
    }
}
