using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.NewsletterQueues.Models;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Mutations {
    /// <summary>
    /// Mutations for newsletter queues
    /// </summary>
    public class NewsletterQueueMutationsBase {

        /// <summary>
        /// Adds subscription items to a newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<NewsletterQueue?> AddSubscriptionItemsToNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.AddSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Creates a newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <param name="newsletterQueue"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<NewsletterQueue?> CreateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, NewsletterQueue newsletterQueue) {
            var response = await newsletterQueueService.Add(newsletterQueue);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Deletes a newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<NewsletterQueue?> DeleteNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id) {
            var response = await newsletterQueueService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes subscription items from a newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <param name="id"></param>
        /// <param name="subscriptionItemIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<NewsletterQueue?> RemoveSubscriptionItemsFromNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, int id, int[] subscriptionItemIds) {
            var response = await newsletterQueueService.RemoveSubscriptionItems(id, subscriptionItemIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Updates a newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <param name="mapper"></param>
        /// <param name="newsletterQueue"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<NewsletterQueue?> UpdateNewsletterQueue([Service] INewsletterQueueService newsletterQueueService, [Service] IMapper mapper, NewsletterQueueUpdateInput newsletterQueue) {
            var response = await newsletterQueueService.Update(mapper.Map<NewsletterQueue>(newsletterQueue));
            return Response.CreateResponse(response);
        }
    }
}