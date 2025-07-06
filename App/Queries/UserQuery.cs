using AWRD.Queries;
using SPAL.App.Models;
using SqlKata;

namespace SPAL.App.Queries
{
    public class UserQuery : SqlQueryTBase<UserTableModel>
    {
        public override string EntityName => UserTableModel.Label;

        public string? Name { get; set; }
        public string? Email { get; set; }

        public override Query BuildBaseQuery()
        {
            return new Query(EntityName);
        }

        private void BuildNameQuery(Query query)
        {
            if(!string.IsNullOrEmpty(Name))
            {
                query.Where(nameof(UserTableModel.Name), "=", Name);
            }
        }

        private void BuildEmailQuery(Query query)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                query.Where(nameof(UserTableModel.Email), "=", Email);
            }
        }

        public override Query BuildCustomQuery(Query query)
        {
            BuildNameQuery(query);
            BuildEmailQuery(query);

            return query;
        }
    }
}