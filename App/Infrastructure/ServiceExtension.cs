using SPAL.App.Clients;
using SPAL.App.Models;
using static SPAL.App.Setting.AppEnv;

namespace SPAL.App.Infrastructure
{
    public static class ServiceExtension
    {
        public static void AddSqlServices(this IServiceCollection services)
        {
            services.AddTransient<ISqlServiceT<UserModel>>(provider =>
            {
                return new SqlServiceT<UserModel>(DatabaseConnectionString);
            });
        }
    }
}