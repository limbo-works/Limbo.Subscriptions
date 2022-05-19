using System.Threading.Tasks;
using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories {
    /// <summary>
    /// A repository for managing newsletter queues
    /// </summary>
    public interface INewsletterQueueRepository : IDbCrudRepositoryBase<NewsletterQueue> {
        /// <summary>
        /// Adds subscription items to a newsletter queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<NewsletterQueue> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items from a newsletter queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<NewsletterQueue> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}
