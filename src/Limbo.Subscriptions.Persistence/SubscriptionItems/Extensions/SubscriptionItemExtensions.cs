using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SubscriptionItemExtensions {
        /// <summary>
        /// Adds subscription items
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubcriptionItems(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
