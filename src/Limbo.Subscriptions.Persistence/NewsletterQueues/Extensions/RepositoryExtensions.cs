using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions {
    /// <summary>
    /// Extentsions
    /// </summary>
    public static class RepositoryExtensions {
        /// <summary>
        /// Adds repositories
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services) {
            services
                .AddTransient<INewsletterQueueRepository, NewsletterQueueRepository>();

            return services;
        }
    }
}
