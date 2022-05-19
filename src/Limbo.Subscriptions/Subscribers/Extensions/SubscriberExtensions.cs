using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Subscribers.Extensions {
    /// <inheritdoc/>
    public static class SubscriberExtensions {
        /// <summary>
        /// Adds subscriber services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
