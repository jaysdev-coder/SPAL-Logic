using System.ComponentModel;
using AWRD.DataService;
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
        internal static async Task<IResult> Get([FromServices]ISqlServiceT<UserModel> userClient)
        {
            var user = await userClient.ExecuteQuery("SELECT TOP (1000) [id], [name], [email] FROM [SPAL].[dbo].[user]");

            return Results.Ok(user);
        }
    }
}