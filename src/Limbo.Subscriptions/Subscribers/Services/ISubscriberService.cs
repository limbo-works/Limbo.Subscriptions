using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Services.Crud;

namespace Limbo.Subscriptions.Subscribers.Services {
    /// <summary>
    /// Service for manaing subscribers
    /// </summary>
    public interface ISubscriberService : ICrudServiceBase<Subscriber, ISubscriberRepository> {

        /// <summary>
        /// Adds categories to a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds);

        /// <summary>
        /// Removes categories from a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds);

        /// <summary>
        /// Adds subscription items to a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items from a subcriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}