using EEntityCore.DB.Modules;
using EEntityCore.MSSQL.WebTest.DBEntities.DatabaseSchema.AuxTables.AuxTables.academic;
using EWebFrameworkCore.Vendor.Configurations;
using EWebFrameworkCore.Vendor.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEntityCore.MSSQL.WebTest
{
    class TestService:BaseClientService
    {
        public TestService(MSSQLConnectionOption connectionOption) : base(connectionOption)
        {
        }

        public void TestExtension()
        {
            using var runner = CreateTransactionRunner(false);

            T___TestTable result = T___TestTable.GetRowWhereIDUsingSQL(1, runner);
            Console.WriteLine("Result was {0}", result.TestString);

            Console.WriteLine(JsonConvert.SerializeObject(runner.Transaction.Queries));

            T___TestTableExtended result2 = result.As<T___TestTableExtended>();
            Console.WriteLine("Result was {0}", result2.AppendedAttribute);
            Console.WriteLine("Result was {0}", result2.TestString);

            runner.ForceDispose();
        }
    }
}
