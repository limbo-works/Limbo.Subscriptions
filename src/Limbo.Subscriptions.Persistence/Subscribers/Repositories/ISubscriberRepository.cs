using System.Threading.Tasks;
using Limbo.EntityFramework.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.Subscribers.Repositories {
    /// <summary>
    /// A repository for managing subscribers
    /// </summary>
    public interface ISubscriberRepository : IDbCrudRepositoryBase<Subscriber> {
        /// <summary>
        /// Adds categories to a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<Subscriber> AddCategories(int id, int[] categoryIds);

        /// <summary>
        /// Removes categories from a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<Subscriber> RemoveCategories(int id, int[] categoryIds);

        /// <summary>
        /// Adds subscription items to a subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<Subscriber> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items froma subscriber
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        Task<Subscriber> RemoveSubscriptionItems(int id, int[] categoryIds);
    }
}
