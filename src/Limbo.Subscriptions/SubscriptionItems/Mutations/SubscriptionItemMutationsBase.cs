using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;

namespace Limbo.Subscriptions.SubscriptionItems.Mutations {

    /// <summary>
    /// Mutations for subscription items
    /// </summary>
    public class SubscriptionItemMutationsBase {

        /// <summary>
        /// Adds categories to a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> AddCategoriesToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] categoryIds) {
            var response = await subscriptionItemService.AddCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Adds newsletter queues to a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> AddNewsletterQueuesToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] newsletterQueueIds) {
            var response = await subscriptionItemService.AddNewsletterQueues(id, newsletterQueueIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Adds subscribers to a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> AddSubscribersToSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] subscriberIds) {
            var response = await subscriptionItemService.AddSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Creates a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="subscriptionItem"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> CreateSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, SubscriptionItem subscriptionItem) {
            var response = await subscriptionItemService.Add(subscriptionItem);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Deletes a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> DeleteSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id) {
            var response = await subscriptionItemService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes categories from a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="categoryIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> RemoveCategoriesFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] categoryIds) {
            var response = await subscriptionItemService.RemoveCategories(id, categoryIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes newsletter queues from a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="newsletterQueueIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> RemoveNewsletterQueuesFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] newsletterQueueIds) {
            var response = await subscriptionItemService.RemoveNewsletterQueues(id, newsletterQueueIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Removes subscribers from a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="id"></param>
        /// <param name="subscriberIds"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> RemoveSubscribersFromSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, int id, int[] subscriberIds) {
            var response = await subscriptionItemService.RemoveSubscribers(id, subscriberIds);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Updates a subscription item
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <param name="mapper"></param>
        /// <param name="subscriptionItem"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionItem?> UpdateSubscriptionItem([Service] ISubscriptionItemService subscriptionItemService, [Service] IMapper mapper, SubscriptionItemUpdateInput subscriptionItem) {
            var response = await subscriptionItemService.Update(mapper.Map<SubscriptionItem>(subscriptionItem));
            return Response.CreateResponse(response);
        }
    }
}