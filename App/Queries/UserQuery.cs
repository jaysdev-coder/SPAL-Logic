using AWRD.Queries;
using SPAL.App.Models;
using SqlKata;

namespace SPAL.App.Queries
{
    public class UserQuery : SqlQueryTBase<UserModel>
    {
        public override string EntityName => UserModel.Label;

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
                query.Where(nameof(UserModel.Name), "=", Name);
            }
        }

        private void BuildEmailQuery(Query query)
        {
            if (!string.IsNullOrEmpty(Email))
            {
                query.Where(nameof(UserModel.Email), "=", Email);
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