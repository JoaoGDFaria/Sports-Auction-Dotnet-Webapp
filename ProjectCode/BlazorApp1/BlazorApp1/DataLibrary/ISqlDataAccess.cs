

namespace DataLibrary
{
    public interface ISqlDataAccess
    {
        public Task<T> ExecuteQuery<T>(string sql, object parameters, string connectionString);
        public Task<List<T>> ExecuteQueryList<T>(string sql, object parameters, string connectionString);
    }
}