using System.Threading.Tasks;
using AutoMapper;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using Limbo.Subscriptions.Bases.GraphQL.Responses;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Services;

namespace Limbo.Subscriptions.SubscriptionSystems.Mutations {
    /// <summary>
    /// Mutations for subscription systems
    /// </summary>
    public class SubscriptionSystemMutationsBase {

        /// <summary>
        /// Creates a subscription system
        /// </summary>
        /// <param name="subscriptionSystemService"></param>
        /// <param name="subscriptionSystem"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionSystem?> CreateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, SubscriptionSystem subscriptionSystem) {
            var response = await subscriptionSystemService.Add(subscriptionSystem);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Deletes a subscription system
        /// </summary>
        /// <param name="subscriptionSystemService"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionSystem?> DeleteSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, int id) {
            var response = await subscriptionSystemService.DeleteById(id);
            return Response.CreateResponse(response);
        }

        /// <summary>
        /// Updates a subscription system
        /// </summary>
        /// <param name="subscriptionSystemService"></param>
        /// <param name="mapper"></param>
        /// <param name="subscriptionSystem"></param>
        /// <returns></returns>
        [Authorize]
        public virtual async Task<SubscriptionSystem?> UpdateSubscriptionSystem([Service] ISubscriptionSystemService subscriptionSystemService, [Service] IMapper mapper, SubscriptionSystemUpdateInput subscriptionSystem) {
            var response = await subscriptionSystemService.Update(mapper.Map<SubscriptionSystem>(subscriptionSystem));
            return Response.CreateResponse(response);
        }
    }
}