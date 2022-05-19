using Limbo.Subscriptions.Subscribers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Subscribers.Extensions {
    /// <inheritdoc/>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds subscriber services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<ISubscriberService, SubscriberService>();

            return services;
        }
    }
}
