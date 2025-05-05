using SPAL.App.Models;
using Microsoft.Data.SqlClient;

namespace SPAL.App.Clients
{
    public class SqlServiceT<T> : ISqlServiceT<T> where T : ITableModel
    {
        private readonly string _connectionString;

        public SqlServiceT(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or empty", nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        public async Task<Stream> GetResultStream(string query)
        {
            throw new NotImplementedException();
        }


        public async Task Submit(string query)
        {
            // Implement Submit method
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<T>> ExecuteQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                throw new ArgumentException("Query cannot be null or empty", nameof(query));
            }

            using var connection = new SqlConnection(_connectionString);

            await connection.OpenAsync();

            using var command = new SqlCommand(query, connection);

            using var reader = await command.ExecuteReaderAsync();

            var results = new List<T>();

            while (await reader.ReadAsync())
            {
                var model = Activator.CreateInstance<T>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var propertyName = reader.GetName(i);
                    var propertyInfo = typeof(T).GetProperty(propertyName);

                    if (propertyInfo != null)
                    {
                        propertyInfo.SetValue(model, reader.GetValue(i));
                    }
                }

                results.Add(model);
            }

            return results.AsReadOnly();
        }
    }
}