using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Xml;
using ClassLibraryXmlizedAttribute;

namespace TestXmlizedAttribute
{
    public partial class Form1 : Form
    {
        private delegate IExportToXmlable ExportToXmlableDelegate(IExportToXmlable e);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestClass testClass = new TestClass
                                      {
                                          ID = 88,
                                          备注 = "beizhu",
                                          计费类型 = "jifeileixing",
                                          拼音码 = "pinyinma",
                                          Enum = MyEnum.是,
                                          Sub =
                                              {
                                                  P1 = "p1",
                                                  P2 = "p2"
                                              }
                                      };
            testClass.Subs.Add(new SubClass { P1 = "01", P2 = "02" });
            testClass.Subs.Add(new SubClass { P1 = "11", P2 = "12" });
            //List<IExportToXmlable> exportToXmlables = testClass.Subs as List<IExportToXmlable>;
            //testClass.Subs.ConvertAll()
            
            //MethodInfo methodInfo = testClass.Subs.GetType().GetMethod("ConvertAll");
            //MethodInfo methodInfoG = methodInfo.MakeGenericMethod(typeof(IExportToXmlable));
            //object[] args = new object[] { new Converter<SubClass, IExportToXmlable>(PointFToPoint) };
            //List<IExportToXmlable> exportToXmlables = methodInfoG.Invoke(testClass.Subs, args) as List<IExportToXmlable>;

            //object o = testClass.GetType().GetProperty("Subs").GetValue(testClass, null);
            //IList subClass = o as IList;
            //foreach (var VARIABLE in subClass)
            //{
            //    IExportToXmlable exportToXmlable = VARIABLE as IExportToXmlable;
            //    MessageBox.Show(exportToXmlable.ExportToXml());
            //}
            //MessageBox.Show(subClass.P1);
            //MessageBox.Show(exportToXmlables.Count.ToString());

            //Assembly assembly = Assembly.GetAssembly(typeof (SubClass));
            //object SubInstance = assembly.CreateInstance(typeof (SubClass).FullName) as IImportFromXmlable;
            //IImportFromXmlable importFromXmlable = SubInstance as IImportFromXmlable;
            //importFromXmlable.ImportFromXml(@"<Sub><P1>21</P1><P2>22</P2><ID>0</ID></Sub>");
            //IList list = testClass.Subs;
            //list.Add(importFromXmlable);

            textBox1.Text = testClass.ExportToXml();
        }
        public static IExportToXmlable PointFToPoint(IExportToXmlable exportToXmlable)
        {
            return exportToXmlable;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Type t = typeof (List<SubClass>);
            if (t.IsGenericType)
            {
                Console.WriteLine(t.GetGenericArguments()[0].GetInterface("IExportToXmlable") == typeof(IExportToXmlable));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestClass testClass=new TestClass();
            testClass.ImportFromXml(textBox1.Text);
            MessageBox.Show(testClass.ID + @";" + testClass.计费类型 + @";" + testClass.拼音码 + @";" + testClass.Enum + @":" + testClass.备注+@":" +testClass.判断 + @":" + testClass.Sub.P1 + @":" + testClass.Sub.P2 + @":" + testClass.Subs[1].P1);
        }
    }
}
