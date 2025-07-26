namespace SPAL.App.Setting
{
    internal static class AppEnv
    {
        private static readonly IConfiguration Configuration;

        static AppEnv()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var appSettingsFile = $"appsettings.{environment}.json";

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(appSettingsFile, optional: false, reloadOnChange: true)
                .Build();
        }

        public static string DatabaseConnectionString
        {
            get
            {
                var connectionString = Configuration["EnvironmentVariables:DatabaseConnectionString"];
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException("DatabaseConnectionString is not configured.");
                }
                return connectionString;
            }
        }
    }
}