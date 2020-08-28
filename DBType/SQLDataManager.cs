using System;
using System.Data;
using System.Data.SqlClient;

namespace DataManager
{
    public class SQLDataManager : IDisposable
    {
        public IDbConnection DbConnection { get; set; }
        public SQLDataManager(string connectionString)
        {
            DbConnection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            if (DbConnection != null)
            {
                DbConnection.Dispose();
                DbConnection = null;
            }
        }
    }
}
