using System.Net;
using System.Threading.Tasks;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Subscribers.Services {
    /// <inheritdoc/>
    public class SubscriberService : CrudServiceBase<Subscriber, ISubscriberRepository>, ISubscriberService {

        /// <inheritdoc/>
        public SubscriberService(ISubscriberRepository repository, ILogger<ServiceBase<ISubscriberRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<ISubscriberRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Subscriber>> Add(Subscriber entity) {
            Subscriber.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> AddCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddCategories(id, categoryIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> RemoveCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveCategories(id, categoryIds);
            }, HttpStatusCode.OK, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Subscriber>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Subscriber>> Update(Subscriber entity) {
            Subscriber.Validate(entity);
            return base.Update(entity);
        }
    }
}
