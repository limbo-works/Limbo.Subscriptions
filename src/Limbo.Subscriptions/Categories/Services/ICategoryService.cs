using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Services.Crud;

namespace Limbo.Subscriptions.Categories.Services {
    /// <summary>
    /// A service for managing categories
    /// </summary>
    public interface ICategoryService : ICrudServiceBase<Category, ICategoryRepository> {

        /// <summary>
        /// Adds subscribers to a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Removes subscribers from a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds);

        /// <summary>
        /// Adds subscription items to a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items from a category
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
