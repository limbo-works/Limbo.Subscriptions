using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.NewsletterQueues.Extensions {
    /// <inheritdoc/>
    public static class NewsletterQueueExtensions {
        /// <summary>
        /// Adds services for newsletter queues
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddNewsletterQueues(this IServiceCollection services) {
            services
                .AddServices();

            return services;
        }
    }
}
