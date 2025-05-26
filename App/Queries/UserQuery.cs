using AWRD.Queries;
using SPAL.App.Models;
using SqlKata;

namespace SPAL.App.Queries
{
    public class UserQuery : SqlQueryTBase<UserModel>
    {
        public override string EntityName => UserModel.Label;

        public override Query BuildBaseQuery()
        {
            return new Query(EntityName);
        }

        public override Query BuildCustomQuery(Query query)
        {
            return query;
        }
    }
}