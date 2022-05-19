using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Subscribers.Services {
    /// <inheritdoc/>
    public class SubscriberService : CrudServiceBase<Subscriber, ISubscriberRepository>, ISubscriberService {

        /// <inheritdoc/>
        public SubscriberService(ISubscriberRepository repository, ILogger<ServiceBase<ISubscriberRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<ISubscriberRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Subscriber>> Add(Subscriber entity) {
            Subscriber.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddCategories(id, categoryIds);
            }, HttpStatusCode.Created, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveCategories(id, categoryIds);
            }, HttpStatusCode.OK, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Subscriber>> Update(Subscriber entity) {
            Subscriber.Validate(entity);
            return base.Update(entity);
        }
    }
}
