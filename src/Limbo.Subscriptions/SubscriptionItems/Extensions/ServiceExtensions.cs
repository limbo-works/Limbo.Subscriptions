using Limbo.Subscriptions.SubscriptionItems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionItems.Extensions {
    /// <inheritdoc/>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds subscription item services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<ISubscriptionItemService, SubscriptionItemService>();

            return services;
        }
    }
}
