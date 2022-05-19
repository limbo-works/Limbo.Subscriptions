using Limbo.Subscriptions.SubscriptionSystems.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.SubscriptionSystems.Extensions {
    /// <inheritdoc/>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds subscription system services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<ISubscriptionSystemService, SubscriptionSystemService>();

            return services;
        }
    }
}
