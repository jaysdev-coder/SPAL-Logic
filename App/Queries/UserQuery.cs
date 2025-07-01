using AWRD.Queries;
using SPAL.App.Models;
using SqlKata;

namespace SPAL.App.Queries
{
    public class UserQuery : SqlQueryTBase<UserReadModel>
    {
        public override string EntityName => UserReadModel.Label;

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
                query.Where(nameof(UserReadModel.Name), "=", Name);
            }
        }

        private void BuildEmailQuery(Query query)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                query.Where(nameof(UserReadModel.Email), "=", Email);
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