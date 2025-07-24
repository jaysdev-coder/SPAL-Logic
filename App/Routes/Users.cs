using System.ComponentModel;
using AutoMapper;
using AWRD.QueryService;
using AWRD.Queries;
using Microsoft.AspNetCore.Mvc;
using SPAL.App.Models;
using SPAL.App.Models.Table;

namespace SPAL.App.Routes
{
    static class User
    {
        public static void MapUser(this IEndpointRouteBuilder app)
        {
            app.MapGet("/users", Get);
        }

        [Description("Get users")]
        internal static async Task<IResult> Get(
            [FromServices] ISqlServiceT<UserTableModel> userClient,
            [FromServices] SqlQueryTBase<UserTableModel> userQuery,
            [FromServices] IMapper mapper)
        {
            var users = await userClient.ExecuteQuery(userQuery.CompileQuery());

            var userReadModels = mapper.Map<IEnumerable<UserReadModel>>(users);

            return TypedResults.Ok(userReadModels);
        }
    }
}