using Framework;
using MyMiniOrm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DemoEntityFrameworkORM.Model;
using System.ComponentModel;
using System.Reflection;

namespace DemoEntityFrameworkORM
{

    public class myClass
    {
        private int a = 1;
        [Description("2描述")]
        public int A { get; set; } = 2;
        [Description("3描述")]
        public int b = 3;
    }

    class Program
    {
        static void Main(string[] args)
        {

            #region 反射：PropertyInfo、FieldInfo和MemberInfo的区别

            //myClass aa = new myClass();
            //PropertyInfo[] pro = aa.GetType().GetProperties();
            //FieldInfo[] fil = aa.GetType().GetFields();
            //MemberInfo[] men = aa.GetType().GetMembers();
            //foreach (var item in pro)
            //{
            //    Console.WriteLine(item.GetValue(aa) + "|" + item.Name + "|" + (item.GetCustomAttributes(typeof(DescriptionAttribute), false).First() as DescriptionAttribute).Description);
            //}
            //Console.WriteLine("FieldInfo的循环");
            //foreach (FieldInfo item in fil)
            //{
            //    Console.WriteLine(item.GetValue(aa) + "|" + item.Name + "|" + (item.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description);
            //}
            //Console.WriteLine("MemberInfo的循环");
            //foreach (MemberInfo item in fil)
            //{
            //    Console.WriteLine("|" + item.Name + "|" + (item.GetCustomAttributes(typeof(DescriptionAttribute)).First() as DescriptionAttribute).Description);
            //}
            #endregion

            //var db = new MyDb("DataSource=.;DataBase=HG;User ID=sa;password=Chendong144216");
            //var cat1 = db.Load<tblCat1>(1);
            //var query = db.Query<tblCat1>();
            //EFContext ef = new EFContext();

            //var materials = ef.tblOrderSubs.Where(s => s.tblMaterial.tblCat3.tblCat2.tblCat1.FCat1 == "产品" && 
            //                                            !s.FFlag.Equals(1))
            //                                .Select(s => new
            //                                {
            //                                    s.tblOrder.FOrderNum,
            //                                    s.tblOrder.FOrderCust,
            //                                    s.tblMaterial.FItem,
            //                                    s.tblMaterial.FSpec,
            //                                    s.FQty
            //                                });

            SqlBuilder sqlBuilder = new SqlBuilder();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ///Select必须在Where之后
            sqlBuilder.GetSql<tblOrderSub>(sl => sl.Where(s => s.tblMaterial.tblCat3.tblCat2.tblCat1.FCat1.Equals("产品") &&
                                                                !s.FFlag.Equals(1)).
                                            Select(s => new
                                            {
                                                s.tblOrder.FOrderNum,
                                                s.tblOrder.FOrderCust,
                                                s.tblMaterial.FItem,
                                                s.tblMaterial.FSpec,
                                                s.FQty
                                            }));
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            stopwatch.Stop();
            //TestFromVisitor();
            Console.ReadKey();

        }

        private static void TestFromVisitor()
        {
            ExpressionVisitorSqlTablesFrom visitorFrom = new ExpressionVisitorSqlTablesFrom();

            Expression<Func<tblOrderSub, object>> expression = s => s.tblMaterial.tblCat3.tblCat2.tblCat1.FCat1;
            visitorFrom.Visit(expression);
        }
    }
}
