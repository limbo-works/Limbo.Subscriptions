using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories {
    /// <inheritdoc/>
    public class NewsletterQueueRepository : DbCrudRepositoryBase<NewsletterQueue>, INewsletterQueueRepository {

        /// <inheritdoc/>
        public NewsletterQueueRepository(IDbContextFactory<SubscriptionDbContext> contextFactory, ILogger<DbCrudRepositoryBase<NewsletterQueue>> logger) : base(contextFactory, logger) {
        }

        /// <inheritdoc/>
        public virtual async Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems);
        }

        /// <inheritdoc/>
        public virtual async Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, newsletterQueue => newsletterQueue.SubscriptionItems);
        }
    }
}
