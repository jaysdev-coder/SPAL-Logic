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
            services.AddTransient<ISqlServiceT<UserTableModel>>(provider =>
            {
                return new SqlServiceT<UserTableModel>(DatabaseConnectionString);
            });
        }

        public static void AddQueryServices(this IServiceCollection services)
        {
            services.AddTransient<SqlQueryTBase<UserTableModel>>(provider =>
            {
                return new UserQuery();
            });
        }
    }
}