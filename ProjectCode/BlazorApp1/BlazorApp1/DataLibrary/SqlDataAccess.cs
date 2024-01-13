using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft;
using System.Data.SqlClient;

namespace DataLibrary
{
    public class SqlDataAccess: ISqlDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<T> ExecuteQuery<T>(string sql, object parameters, string connectionString)
        {
            using (IDbConnection connection = new SqlConnection(connectionString)) // Change here
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



        public String GetClient(string sql, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var rows = connection.Query<string>(sql);

                return rows.FirstOrDefault() ?? string.Empty;
            }
        }




    }
}
