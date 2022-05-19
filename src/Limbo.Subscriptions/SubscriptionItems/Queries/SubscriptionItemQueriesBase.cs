using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.SubscriptionItems.Services;

namespace Limbo.Subscriptions.SubscriptionItems.Queries {

    /// <summary>
    /// Queries for subscription items
    /// </summary>
    public class SubscriptionItemQueriesBase {

        /// <summary>
        /// Gets a subscription item by id
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <returns></returns>
        [Authorize]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionItem>?> GetSubscriptionItemById([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            return response;
        }

        /// <summary>
        /// Gets subscription items
        /// </summary>
        /// <param name="subscriptionItemService"></param>
        /// <returns></returns>
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionItem>> GetSubscriptionItems([Service] ISubscriptionItemService subscriptionItemService) {
            var response = (await subscriptionItemService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<SubscriptionItem>().AsQueryable();
            }
        }
    }
}