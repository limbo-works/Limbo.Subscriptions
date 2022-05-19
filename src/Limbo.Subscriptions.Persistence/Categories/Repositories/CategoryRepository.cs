using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.Categories.Repositories {
    /// <inheritdoc/>
    public class CategoryRepository : DbCrudRepositoryBase<Category>, ICategoryRepository {

        /// <inheritdoc/>
        public CategoryRepository(IDbContextFactory<SubscriptionDbContext> contextFactory, ILogger<DbCrudRepositoryBase<Category>> logger) : base(contextFactory, logger) {
        }

        /// <inheritdoc/>
        public virtual async Task<Category> AddSubscribers(int id, int[] subscriberIds) {
            return await AddToCollection(id, subscriberIds, category => category.Subscribers);
        }

        /// <inheritdoc/>
        public virtual async Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await AddToCollection(id, subscriptionItemIds, category => category.SubscriptionItems);
        }

        /// <inheritdoc/>
        public virtual async Task<Category> RemoveSubscribers(int id, int[] subscriberIds) {
            return await RemoveFromCollection(id, subscriberIds, category => category.Subscribers);
        }

        /// <inheritdoc/>
        public virtual async Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await RemoveFromCollection(id, subscriptionItemIds, category => category.SubscriptionItems);
        }
    }
}
