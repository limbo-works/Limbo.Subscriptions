using System.Net;
using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Repositories;
using Microsoft.Extensions.Logging;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;

namespace Limbo.Subscriptions.SubscriptionItems.Services {
    /// <inheritdoc/>
    public class SubscriptionItemService : CrudServiceBase<SubscriptionItem, ISubscriptionItemRepository>, ISubscriptionItemService {

        /// <inheritdoc/>
        public SubscriptionItemService(ISubscriptionItemRepository repository, ILogger<ServiceBase<ISubscriptionItemRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<ISubscriptionItemRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<SubscriptionItem>> Add(SubscriptionItem entity) {
            SubscriptionItem.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> AddCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddCategories(id, categoryIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> AddNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddNewsletterQueues(id, newsletterQueueIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> AddSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> RemoveCategories(int id, int[] categoryIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveCategories(id, categoryIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> RemoveNewsletterQueues(int id, int[] newsletterQueueIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveNewsletterQueues(id, newsletterQueueIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<SubscriptionItem>> RemoveSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<SubscriptionItem>> Update(SubscriptionItem entity) {
            SubscriptionItem.Validate(entity);
            return base.Update(entity);
        }
    }
}
