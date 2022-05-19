using Limbo.Subscriptions.NewsletterQueues.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.NewsletterQueues.Extensions {
    /// <inheritdoc/>
    public static class ServiceExtensions {
        /// <summary>
        /// Adds newsletter queue services
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services) {
            services
                .AddTransient<INewsletterQueueService, NewsletterQueueService>();

            return services;
        }
    }
}
