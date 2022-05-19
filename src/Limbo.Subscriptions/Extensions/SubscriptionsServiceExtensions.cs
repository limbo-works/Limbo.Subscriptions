using Limbo.Subscriptions.Categories.Extensions;
using Limbo.Subscriptions.NewsletterQueues.Extensions;
using Limbo.Subscriptions.Subscribers.Extensions;
using Limbo.Subscriptions.SubscriptionItems.Extensions;
using Limbo.Subscriptions.SubscriptionSystems.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Extensions {
    /// <inheritdoc/>
    public static class SubscriptionsServiceExtensions {

        /// <summary>
        /// Adds services for the subscription package
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSubscriptionServices(this IServiceCollection services) {
            services
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubscriptionItems()
                .AddSubscriptionSystems();

            return services;
        }
    }
}