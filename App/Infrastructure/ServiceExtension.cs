using AWRD.DataService;
using AWRD.Queries;
using SPAL.App.Models;
using SPAL.App.Queries;
using static SPAL.App.Setting.AppEnv;

namespace SPAL.App.Infrastructure
{
    public static class ServiceExtension
    {
        public static void AddSqlServices(this IServiceCollection services)
        {
            services.AddTransient<ISqlServiceT<UserReadModel>>(provider =>
            {
                return new SqlServiceT<UserReadModel>(DatabaseConnectionString);
            });
        }

        public static void AddQueryServices(this IServiceCollection services)
        {
            services.AddTransient<SqlQueryTBase<UserReadModel>>(provider =>
            {
                return new UserQuery();
            });
        }
    }
}