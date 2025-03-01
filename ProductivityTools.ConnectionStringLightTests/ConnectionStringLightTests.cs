using System;
using ProductivityTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace ConnectionStringLightPTTests
{
    [TestClass]
    public class ConnectionStringLightTests
    {
        [TestMethod]
        public void SQLDataSourceConnectionString()
        {
            var x = ConnectionStringLight.GetSqlDataSourceConnectionString(".");
            Assert.AreEqual(x, "Data Source=.;Integrated Security=True");

            var a = ConnectionStringLight.GetSqlDataSourceConnectionString(".", true);
            Assert.AreEqual(a, "Data Source=.;Integrated Security=True;Trust Server Certificate=True");

            var y = ConnectionStringLight.GetSqlServerConnectionString(".", "dbName");
            Assert.AreEqual(y, "Data Source=.;Initial Catalog=dbName;Integrated Security=True");


            var z = ConnectionStringLight.GetSqlServerConnectionString(".", "dbName", true);
            Assert.AreEqual(z, "Data Source=.;Initial Catalog=dbName;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
