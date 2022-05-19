using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Subscribers.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adss repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddTransient<ISubscriberRepository, SubscriberRepository>();

            return services;
        }
    }
}
