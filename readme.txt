
从本次开始，在此文件中记录各版本新增和修改内容，本次，最后完毕于，“药品种类价格调整”。
20090811
增加药库信息管理
20090819
调整一下两个模块：ClassLibraryAbstractDataInformation、ClassLibrarySQLExecute，使之适应复杂数据的增加，调整不影响已知模块的使用。


取消生产批号前

Start:2012-10-18

2012-10-18: 目标框架改为.net framwork 4.0 client profile

分级说明：
L0：不依赖于其他程序集。
L1：只依赖于L0。
L2：依赖于L1或其他L2，但不直接服务于L4。
L3：直接服务于L4。
L4：有UI界面。

()(L0[];L1[];L2[];L3[])

1.ClassLibraryEventArgs(L0)

2.ClassLibraryGetSQLString(L0)

3.ClassLibraryLoginInformation(L0)

4.ClassLibraryXmlizedAttribute(L0)

5.ClassLibrarySQLExcute(L1)(1,3)

6.ClassLibraryAuthoritySet(L2)(L0[1,2,3],L1[5])

7.ClassLibraryPublicEnum(Level 0)

8.ClassLibraryAbstractDataInformation(L2)(L0[1,3,4,7],L1[5],L2[6])

9.ClassLibraryDataTableFromQueryString(L0)

10.ClassLibraryMedicineStock(L3)(L3)(L0[1,2,3,4,9];L1[5];L2[8];L3[])

11.ClassLibraryCostItems(L3)(L0[1,2,4,9];L1[];L2[8];L3[])

12.ClassLibraryCostItemUnit(L3)(L0[1,4];L1[];L2[8];L3[])

13.ClassLibraryCostType(L3)(L0[1,2,4,9];L1[];L2[8];L3[])

14.ClassLibraryCostItemAdjustPrice(L3)(L0[2,4,9];L1[];L2[8];L3[11])

15.ClassLibraryMedicineKind(L3)(L0[1,2,4,7,9];L1[5];L2[8];L3[])

16.ClassLibraryMedicineKindAdjustPrice(L3)(L0[4];L1[];L2[8];L3[15])

17.ClassLibraryMedicineProductionBatch(L2)(L0[1,2,3,4];L1[5];L2[8];L3[])

18.ClassLibraryQuantityUnit(L3)(L0[1,2,49];L1[];L2[8];L3[])

19.ClassLibraryDepartmentInformation(L3)(L0[1,4];L1[];L2[8];L3[])

20.ClassLibraryPYM(L0)(L0[2,3,9];L1[5];L2[8];L3[])

21.CustomForm(L2)(L0[1,2,3,4,9,20];L1[];L2[8];L3[])

22.ClassLibraryWorkerInformations(L3)(L0[1,2,3,4,9];L1[];L2[8];L3[])

23.ClassLibraryMedicineStoreHouseInfomation(L3)(L0[1,2,4,7,9];L1[];L2[8];L3[])

24.ClassLibrarySupplier(L3)(L0[1,2,4,9];L1[];L2[8];L3[])

25.ClassLibraryDepartmentReassignment(L3)(L0[2,3,4,9];L1[5];L2[8];L3[22])

26.ClassLibraryDataListColumnShowInformationConfig(L0)(L0[];L1[];L2[];L3[])

27.ClassLibraryAccountingPeriodInformation(L2)(L0[2,3,4];L1[5];L2[8];L3[])

28.ClassLibraryDataListLoad(L1)(L0[1,3,9];L1[];L2[8];L3[])

29.ClassLibraryAbstractFormDataListBase(L2)(L0[1,2,3,9,26];L1[28];L2[21];L3[])

30.QuantityUnit(L4)(L0[1,2,3,4];L1[];L2[8,21,29];L3[18])

31.DateSelectControl(L2)(L0[4,7];L1[];L2[8,27];L3[])

32.TextBoxWithButton(L2)(L0[];L1[];L2[];L3[])

33.MedicineBatchControl(L2)(L0[1,2,3,4,7];L1[5];L2[8,17,32];L3[15])

34.MedicineKindSelectControl(L2)(L0[];L1[];L2[32];L3[15])

35.MedicineStoreHouseSelector(L2)(L0[7];L1[];L2[32];L3[23])

36.WorkerSelectorControl(L2)(L0[];L1[];L2[32];L3[22])

37.SupplierSelectorlControl(L2)(L0[];L1[];L2[32];L3[24])

38.DepartmentReassignment(L3)(L0[1,2,3,4];L1[];L2[8,21,29];L3[22,25])

39.DepartmentInformation(L4)(L0[1,2,3,4];L1[];L2[8,21,29,32];L3[19])

40.Supplier(L4)(L0[1,2,3,4];L1[L4];L2[8,21,29,32];L3[24])

41.CostType(L4)(L0[1,2,3,4];L1[L4];L2[8,21,29,32];L3[13])

42.CostItemAdjustPrice(L3)(L0[1,2,3,4];L1[];L2[8,21,29,32];L3[11,14])

43.CostItems(L4)(L0[];L1[1,2,3,4];L2[8,21,29,32];L3[11,13,42])

44.CostItemUnit(L4)(L0[1,2,3,4];L1[];L2[8,21,29];L3[12])

45.MedicineStoreHouseInformation(L4)(L0[1,2,3,4];L1[];L2[8,21,29,32];L3[23])

46.MedicineKindAdjustPrice(L3)(L0[1,2,3,4];L1[];L2[8,21,29,32];L3[15,16])

47.MedicineKinds(L4)(L0[1,2,3,4,7];L1[];L2[8,21,29,32];L3[13,15,18,46])

48.WorkerInformations()(L0[1,2,3,4,7];L1[];L2[8,21,29,32];L3[22,38])

2012-10-29:所有前期已完成的项目转换完毕(目标框架改为.net framwork 4.0 client profile)

2012-10-30:关于药品生产批号的操作调整如下：
	1、继续记录并生成药品生产批号（留日后做开发）。
	2、不反映生产批号的库存信息，只反映药品种类的库存信息。

49.VerifyDifferSelector()(L0[];L1[];L2[];L3[])--审核意见控件

50.MedicineStock()(L0[];L1[];L2[];L3[])


2013-3-22:升级开发工具至VS2012


















