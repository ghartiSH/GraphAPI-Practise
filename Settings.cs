
using Microsoft.Extensions.Configuration;
namespace GraphTutorial
{
    internal class Settings
    {
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? TenantId { get; set; }
        public string? AuthTenant { get; set; }
        public string[]? GraphUserScopes { get; set; }

        public static Settings LoadSettings()
        {
            // Load settings
            IConfiguration config = new ConfigurationBuilder()
                // appsettings.json is required
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            return config.GetRequiredSection("Settings").Get<Settings>();
        }
    }
}
