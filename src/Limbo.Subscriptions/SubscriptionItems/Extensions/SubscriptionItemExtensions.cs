using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionItems.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionItemExtensions {
        /// <summary>
        /// Adds subscription item services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionItems(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
