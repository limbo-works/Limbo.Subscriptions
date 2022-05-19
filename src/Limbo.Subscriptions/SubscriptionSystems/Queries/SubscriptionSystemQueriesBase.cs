using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.SubscriptionSystems.Services;

namespace Limbo.Subscriptions.SubscriptionSystems.Queries {
    /// <summary>
    /// Queries for subscription systems
    /// </summary>
    public class SubscriptionSystemQueriesBase {

        /// <summary>
        /// Gets a subscription system by id
        /// </summary>
        /// <param name="subscriptionSystemService"></param>
        /// <returns></returns>
        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionSystem>?> GetSubscriptionSystemById([Service] ISubscriptionSystemService subscriptionSystemService) {
            var response = (await subscriptionSystemService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            return response;
        }

        /// <summary>
        /// Gets subscription systems
        /// </summary>
        /// <param name="subscriptionSystemService"></param>
        /// <returns></returns>
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<SubscriptionSystem>> GetSubscriptionSystems([Service] ISubscriptionSystemService subscriptionSystemService) {
            var response = (await subscriptionSystemService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<SubscriptionSystem>().AsQueryable();
            }
        }
    }
}