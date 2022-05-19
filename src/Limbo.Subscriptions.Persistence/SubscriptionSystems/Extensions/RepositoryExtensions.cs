using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Add repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddTransient<ISubscriptionSystemRepository, SubscriptionSystemRepository>();

            return services;
        }
    }
}
