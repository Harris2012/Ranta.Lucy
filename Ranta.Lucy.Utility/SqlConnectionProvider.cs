namespace Ranta.Lucy.Utility
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

    public class SqlConnectionProvider
    {
        public SqlConnection GetConnection()
        {
            var connString = ConfigurationManager.ConnectionStrings["LucyMaster"].ConnectionString;

            SqlConnection sqlConn = new SqlConnection(connString);

            sqlConn.Open();

            return sqlConn;
        }
    }
}
