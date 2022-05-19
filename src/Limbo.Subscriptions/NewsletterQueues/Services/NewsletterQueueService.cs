using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.NewsletterQueues.Services {
    /// <inheritdoc/>
    public class NewsletterQueueService : CrudServiceBase<NewsletterQueue, INewsletterQueueRepository>, INewsletterQueueService {

        /// <inheritdoc/>
        public NewsletterQueueService(INewsletterQueueRepository repository, ILogger<ServiceBase<INewsletterQueueRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<INewsletterQueueRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<NewsletterQueue>> Add(NewsletterQueue entity) {
            NewsletterQueue.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<NewsletterQueue>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, IsolationLevel.Serializable);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<NewsletterQueue>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, IsolationLevel.Serializable);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<NewsletterQueue>> Update(NewsletterQueue entity) {
            NewsletterQueue.Validate(entity);
            return base.Update(entity);
        }
    }
}
