using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SubscriptionSystemExtensions {
        /// <summary>
        /// Adds subscription systems
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
