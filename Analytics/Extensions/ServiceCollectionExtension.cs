using Microsoft.Extensions.DependencyInjection;

namespace Meergo.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddAnalytics(this IServiceCollection services, string writeKey, Config config = null)
        {
            Config configuration;

            if(config == null)
                configuration = new Config();
            else
                configuration = config;

            var client = new Client(writeKey, configuration);
            services.AddSingleton<IAnalyticsClient>(client);
        }
    }
}
