using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Services {
    /// <summary>
    /// A service for managing newsletter queues
    /// </summary>
    public interface INewsletterQueueService : ICrudServiceBase<NewsletterQueue, INewsletterQueueRepository> {

        /// <summary>
        /// Adds subscription items to a newsletter queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds);

        /// <summary>
        /// Removes subscription items from a newsletter queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds);
    }
}