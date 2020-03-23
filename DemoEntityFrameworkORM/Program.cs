using Framework;
using MyMiniOrm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoEntityFrameworkORM
{
    class Program
    {
        static void Main(string[] args)
        {
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
            ///Select必须在Where之后
            sqlBuilder.GetSql<tblOrderSub>(sl => sl.Where(s => !s.tblMaterial.tblCat3.tblCat2.tblCat1.FCat1.Equals("产品") && 
                                                                !s.FFlag.Equals(1)).
                                            Select(s => new
                                            {
                                                s.tblOrder.FOrderNum,
                                                s.tblOrder.FOrderCust,
                                                s.tblMaterial.FItem,
                                                s.tblMaterial.FSpec,
                                                s.FQty
                                            }));
            Console.ReadKey();
        }
    }
}
