using System.Data;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using HotChocolate.AspNetCore.Authorization;
using HotChocolate.Data;
using HotChocolate.Types;
using Limbo.Subscriptions.NewsletterQueues.Services;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;

namespace Limbo.Subscriptions.NewsletterQueues.Queries {
    /// <summary>
    /// Queries for newsletter queues
    /// </summary>
    public class NewsletterQueueQueriesBase {

        /// <summary>
        /// Gets a newsletter queue by id
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <returns></returns>
        [Authorize]
        [UseFirstOrDefault]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<NewsletterQueue>?> GetNewsletterQueueById([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            return response;
        }

        /// <summary>
        /// Gets newsletter queue
        /// </summary>
        /// <param name="newsletterQueueService"></param>
        /// <returns></returns>
        [Authorize]
        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public virtual async Task<IQueryable<NewsletterQueue>> GetNewsLetterQueues([Service] INewsletterQueueService newsletterQueueService) {
            var response = (await newsletterQueueService.QueryDbSet(IsolationLevel.ReadCommitted)).ResponseValue;
            if (response is not null) {
                return response;
            } else {
                return Enumerable.Empty<NewsletterQueue>().AsQueryable();
            }
        }
    }
}