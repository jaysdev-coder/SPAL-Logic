using System.ComponentModel;
using AWRD.DataService;
using AWRD.Queries;
using Microsoft.AspNetCore.Mvc;
using SPAL.App.Models;

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
            [FromServices]ISqlServiceT<UserTableModel> userClient, 
            [FromServices]SqlQueryTBase<UserTableModel> userQuery)
        {
            var user = await userClient.ExecuteQuery(userQuery.CompileQuery());

            return TypedResults.Ok(user);
        }
    }
}