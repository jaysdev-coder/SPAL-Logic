using SPAL.App.Clients;
using SPAL.App.Models;

namespace SPAL.App.Infrastructure
{
    static partial class ServiceExtension
    {
        public static void AddSqlServices(this IServiceCollection services)
        {
            services.AddTransient<ISqlServiceT<UserModel>, SqlServiceT<UserModel>>();
        }
    }
}
