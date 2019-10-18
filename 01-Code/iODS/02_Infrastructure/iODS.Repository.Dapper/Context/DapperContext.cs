using System.Data.SqlClient;
using Hollysys.Common;
using iODS.Model;
using Z.Dapper.Plus;

namespace iODS.Repository.Dapper.Context
{
    public class DapperContext
    {
        public DapperContext()
        {
            DapperPlusManager.Entity<Department>().Table("SM_Department").Key(x => x.Id);
            var sqlConnection = new SqlConnection(DatabaseConfig.ConnectionString);
            sqlConnection.Open();
            SqlCommand a = sqlConnection.CreateCommand();
           
        }
    }
}