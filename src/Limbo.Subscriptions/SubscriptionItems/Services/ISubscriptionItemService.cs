using System.Threading.Tasks;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories;

namespace Limbo.Subscriptions.SubscriptionItems.Services {
    /// <summary>
    /// Service for managing subscription items
    /// </summary>
    public interface ISubscriptionItemService : ICrudServiceBase<SubscriptionItem, ISubscriptionItemRepository> {

        /// <summary>
        /// Adds categories to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> AddCategories(int id, int[] categoryIds);

        /// <summary>
        /// Removes categories from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> RemoveCategories(int id, int[] categoryIds);

        /// <summary>
        /// Adds subscribers to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> AddSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Removes subscribers from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> RemoveSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Adds newsletter queues to a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> AddNewsletterQueues(int id, int[] newsletterQueueIds);

        /// <summary>
        /// Removes newsletter queues from a subscription item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<SubscriptionItem>> RemoveNewsletterQueues(int id, int[] newsletterQueueIds);
    }
}