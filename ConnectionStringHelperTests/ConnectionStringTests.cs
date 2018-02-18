using System;
using ConnectionStringLightHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConnectionStringLightHelperTests
{
    [TestClass]
    public class ConnectionStringTests
    {
        [TestMethod]
        public void SQLDataSourceConnectionString()
        {
            var x=ConnectionStringLight.GetSqlDataSourceConnectionString(".");
            Assert.AreEqual(x, "Data Source=.;Integrated Security=True");

            var y = ConnectionStringLight.GetSqlServerConnectionString(".", "dbName");
            Assert.AreEqual(y, "Data Source=.;Initial Catalog=dbName;Integrated Security=True");
        }
    }
}
