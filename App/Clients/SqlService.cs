﻿using Microsoft.Data.SqlClient;

namespace SPAL.App.Clients
{
    public class SqlService : ISqlService
    {
        private string ConnectionString { get; init; }

        public SqlService(string connectionString) => ConnectionString = connectionString;

        public Task<Stream> GetResultStream(string query)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<dynamic>> SubmitQuery(string query)
        {
            throw new NotImplementedException();
        }

        public Task Submit(string query)
        {
            throw new NotImplementedException();
        }
    }
}
