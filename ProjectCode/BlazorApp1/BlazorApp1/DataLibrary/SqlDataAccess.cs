using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using System.Data.SqlClient;

namespace DataLibrary
{
    public class SqlDataAccess: ISqlDataAccess
    {

        public async Task<T> ExecuteQuery<T>(string sql, object parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var result = await connection.ExecuteScalarAsync<T>(sql, parameters);
                return result ?? default(T)!;
            }
        }

        public async Task<List<T>> ExecuteQueryList<T>(string sql, object parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var results = await connection.QueryAsync<T>(sql, parameters);
                return results.ToList();
            }
        }

    }
}
