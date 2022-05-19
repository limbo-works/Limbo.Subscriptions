using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Subscribers.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class SubscriberExtensions {
        /// <summary>
        /// Adds subscribers
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscribers(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
