using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class NewsletterQueueExtensions {
        /// <summary>
        /// Adds newsletter queues
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddRepositories();

            return services;
        }
    }
}
