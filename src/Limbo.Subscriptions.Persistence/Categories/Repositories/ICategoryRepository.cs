using System.Threading.Tasks;
using Limbo.EntityFramework.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Categories.Models;

namespace Limbo.Subscriptions.Persistence.Categories.Repositories {
    /// <summary>
    /// A repository for managing categories
    /// </summary>
    public interface ICategoryRepository : IDbCrudRepositoryBase<Category> {
        /// <summary>
        /// Adds subscribers to a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<Category> AddSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Removes subscribers from a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<Category> RemoveSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Adds subscription items to a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<Category> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items from a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<Category> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
