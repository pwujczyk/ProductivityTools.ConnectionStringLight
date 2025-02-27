using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductivityTools
{
    public static class ConnectionStringLight
    {
        /// <summary>
        /// Returns connection string only with sql server name. Used for creating new database.
        /// Example: Data Source=.\sqlServerInstance;Integrated Security=True
        /// </summary>
        /// <param name="dataSource"></param>
        /// <returns></returns>
        public static string GetSqlDataSourceConnectionString(string dataSource)
        {
            return GetSQLDataSource(dataSource).ToString();
        }

        /// <summary>
        /// Returns connection string with datasource and database name
        /// Example: Data Source=.\sqlServerInstance;Initial Catalog=DatabaseName;Integrated Security=True
        /// </summary>
        /// <param name="datasource"></param>
        /// <param name="databaseName"></param>
        /// <returns></returns>
        public static string GetSqlServerConnectionString(string datasource, string databaseName, bool? trustServerCertificate = null)
        {
            var connection = GetDataSource(datasource).AddIntegratedSecurity().AddInitialCatalog(databaseName);
                if (trustServerCertificate.HasValue)
            {
                connection.AddTrustServerCertificate(trustServerCertificate.Value);
            }

            return connection.ToString();
        }

        private static SqlConnectionStringBuilder GetSQLDataSource(string dataSource)
        {
            var r = GetDataSource(dataSource).AddIntegratedSecurity();
            return r;
        }

        private static SqlConnectionStringBuilder GetDataSource(string dataSource)
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = dataSource;
            return sqlBuilder;
        }

        private static SqlConnectionStringBuilder AddIntegratedSecurity(this SqlConnectionStringBuilder connectionStringBuilder)
        {
            connectionStringBuilder.IntegratedSecurity = true;
            return connectionStringBuilder;
        }

        private static SqlConnectionStringBuilder AddInitialCatalog(this SqlConnectionStringBuilder connectionStringBuilder, string initialCatalog)
        {
            connectionStringBuilder.InitialCatalog = initialCatalog;
            return connectionStringBuilder;
        }

        private static SqlConnectionStringBuilder AddTrustServerCertificate(this SqlConnectionStringBuilder connectionStringBuilder, bool trustServerCertificate)
        {
            connectionStringBuilder.TrustServerCertificate = trustServerCertificate;
            return connectionStringBuilder;
        }
    }
}
