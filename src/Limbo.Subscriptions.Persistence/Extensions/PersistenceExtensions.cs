using Limbo.DataAccess.Extensions;
using Limbo.Subscriptions.Persistence.Categories.Extensions;
using Limbo.Subscriptions.Persistence.Contexts.Extensions;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Extensions;
using Limbo.Subscriptions.Persistence.Subscribers.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Extensions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Limbo.Subscriptions.Persistence.Extensions {
    /// <summary>
    /// Extensions
    /// </summary>
    public static class PersistenceExtensions {
        /// <summary>
        /// Adds persistence
        /// </summary>
        /// <param name="services"></param>
        /// <param name="subscriptionPersistenceOptions"></param>
        /// <returns></returns>
        public static IServiceCollection AddPersistence(this IServiceCollection services, SubscriptionPersistenceOptions subscriptionPersistenceOptions) {
            services
                .AddContexts(subscriptionPersistenceOptions.ContextOptions)
                .AddCategories()
                .AddNewsletterQueues()
                .AddSubscribers()
                .AddSubcriptionItems()
                .AddSubscriptionSystems()
                .AddDataAccess(subscriptionPersistenceOptions.DataAccessOptions);

            return services;
        }
    }
}
