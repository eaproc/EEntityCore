using EEntityCore.MSSQL.WebTest.DBEntities;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic;
using System;

namespace EEntityCore.MSSQL.WebTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseInit.DBConnectInterface = new DatabaseInit("SalesSCADWARE", "sa", "netEPRO@2017", 51391, @"localhost\SQLSERVER2016");

            T___AcademicSession academicSession = T___AcademicSession.getFullTable();


            Console.WriteLine(academicSession.getFirstRow().Name);
        }
    }
}
