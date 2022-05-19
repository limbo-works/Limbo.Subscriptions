using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories {
    /// <summary>
    /// A repository for managing subscription items
    /// </summary>
    public interface ISubscriptionItemRepository : IDbCrudRepositoryBase<SubscriptionItem> {
        /// <summary>
        /// Adds categories to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> AddCategories(int id, int[] categoryIds);

        /// <summary>
        /// Adds newsletter queues to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> AddNewsletterQueues(int id, int[] newsletterQueueIds);

        /// <summary>
        /// Adds subscribers to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> AddSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Removes categories from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> RemoveCategories(int id, int[] categoryIds);

        /// <summary>
        /// Removes newsletter queues from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> RemoveNewsletterQueues(int id, int[] newsletterQueueIds);

        /// <summary>
        /// Removes subscribers from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<SubscriptionItem> RemoveSubscribers(int id, int[] subscriberIds);
    }
}
