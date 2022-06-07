using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.NewsletterQueues.Services {
    /// <inheritdoc/>
    public class NewsletterQueueService : CrudServiceBase<NewsletterQueue, INewsletterQueueRepository>, INewsletterQueueService {

        /// <inheritdoc/>
        public NewsletterQueueService(INewsletterQueueRepository repository, ILogger<ServiceBase<INewsletterQueueRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<INewsletterQueueRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<NewsletterQueue>> Add(NewsletterQueue entity) {
            NewsletterQueue.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, IsolationLevel.Serializable);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, IsolationLevel.Serializable);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<NewsletterQueue>> Update(NewsletterQueue entity) {
            NewsletterQueue.Validate(entity);
            return base.Update(entity);
        }
    }
}
