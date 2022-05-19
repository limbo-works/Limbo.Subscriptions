using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionSystems.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionSystemExtensions {
        /// <summary>
        /// Adds services for subscription systems
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionSystems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
