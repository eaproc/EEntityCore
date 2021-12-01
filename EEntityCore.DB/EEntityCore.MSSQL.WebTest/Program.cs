using EEntityCore.DB.MSSQL;
using EEntityCore.MSSQL.WebTest.DBEntities;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic;
using Newtonsoft.Json;
using System;

namespace EEntityCore.MSSQL.WebTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                DatabaseInit.DBConnectInterface = new DatabaseInit("SalesSCADWARE", "sa", "netEPRO@2017", 51391, @"localhost\SQLSERVER2016");

                TestUpdate();

                //TestFetch();

                //TestDelete();

                //TestAddWithID();

                //TestAdd();

                //TestInsertGetID();


                //T___AcademicSession academicSession = T___AcademicSession.GetFullTable();


                //Console.WriteLine(JsonConvert.SerializeObject(
                //        academicSession.GetFirstRow().TargettedRow.ItemArray, 
                //        formatting: Formatting.Indented
                //        )
                //    );

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }
        }

        private static void TestFetch()
        {
            T___TestTable result = T___TestTable.GetFullTable();
            Console.WriteLine("Result was {0}", result.RowCount);

            result = T___TestTable.GetRowWhereIDUsingSQL(1);
            Console.WriteLine("Result was {0}", result.TestInt32);
        }


        private static void TestUpdate()
        {

            //T___TestTable.UpdateQueryBuilder builder = new T___TestTable.UpdateQueryBuilder(1);
            //builder.SetTestString("This is getting hilarious").SetTestBool(true).SetTestInt32(5500);

            //Console.WriteLine("Result was [{0}]", builder.BuildSQL());

            T___TestTable result = T___TestTable.GetRowWhereIDUsingSQL(1);
            Console.WriteLine("Result was {0}", result.TestString);

            //// Testing Mutilators
            //result.TestString = "What is happening";
            //Console.WriteLine("Result was {0}", result.TestString);

            result.TestString = "This is getting hilarious";

            T___TestTable.UpdateQueryBuilder builder2 = new T___TestTable.UpdateQueryBuilder(result);
            //builder2.SetTestString("This is getting hilarious").SetTestBool(true).SetTestInt32(5500);
            Console.WriteLine("SQL: [{0}]", builder2.BuildSQL());

            result.Update(reloadTable: true);


            Console.WriteLine("After Update [{0}]", result.TestString);


        }


        private static void TestDelete()
        {
            T___TestTable result = T___TestTable.GetRowWhereIDUsingSQL(3);
            Console.WriteLine("Result was {0}", result.TestInt32);

            var r = result.DeleteRow();
            Console.WriteLine("Result was {0}", r);

        }


        private static void TestAddWithID()
        {
           bool result =   T___TestTable.AddWithID(2, "Funny", 400, true, (decimal)10.244, DateTime.Now);
           Console.WriteLine("Result was {0}", result);
        }

        private static void TestAdd()
        {
            bool result = T___TestTable.Add("Funny Add", 65400, true, (decimal)10.244, DateTime.Now);
            Console.WriteLine("Result was {0}", result);
        }

        private static void TestInsertGetID()
        {
            //using var transaction = new DBTransaction( DatabaseInit.DBConnectInterface.GetDBConn().GetSQLConnection());
            long result = T___TestTable.InsertGetID("Funny", 400, true, (decimal)10.244, DateTime.Now, transaction: null);
            Console.WriteLine("Result was {0}", result);
        }
    }
}
