using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories {
    /// <inheritdoc/>
    public class SubscriptionItemRepository : DbCrudRepositoryBase<SubscriptionItem>, ISubscriptionItemRepository {
        /// <inheritdoc/>
        public SubscriptionItemRepository(IDbContextFactory<SubscriptionDbContext> contextFactory, ILogger<DbCrudRepositoryBase<SubscriptionItem>> logger) : base(contextFactory, logger) {
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> AddCategories(int id, int[] categoryIds) {
            return await AddToCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories);
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> AddNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await AddToCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues);
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers);
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> RemoveCategories(int id, int[] categoryIds) {
            return await RemoveFromCollection(id, categoryIds, subscriptionItem => subscriptionItem.Categories);
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> RemoveNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await RemoveFromCollection(id, newsletterQueueIds, subscriptionItem => subscriptionItem.NewsletterQueues);
        }

        /// <inheritdoc/>
        public virtual async Task<SubscriptionItem> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, subscriptionItem => subscriptionItem.Subscribers);
        }
    }
}
