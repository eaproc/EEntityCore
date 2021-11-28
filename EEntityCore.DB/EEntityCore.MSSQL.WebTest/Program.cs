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


                //TestAdd();

                TestInsertGetID();


                T___AcademicSession academicSession = T___AcademicSession.GetFullTable();


                Console.WriteLine(JsonConvert.SerializeObject(
                        academicSession.GetFirstRow().TargettedRow.ItemArray, 
                        formatting: Formatting.Indented
                        )
                    );

            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex);
            }
        }

        private static void TestAdd()
        {
           bool result =   T___TestTable.Add(2, "Funny", 400, true, (decimal)10.244, DateTime.Now);
           Console.WriteLine("Result was {0}", result);
        }

        private static void TestInsertGetID()
        {
            string result = T___TestTable.InsertGetID("Funny", 400, true, (decimal)10.244, DateTime.Now);
            Console.WriteLine("Result was {0}", result);
        }
    }
}
