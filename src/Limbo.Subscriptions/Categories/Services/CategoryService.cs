using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Microsoft.Extensions.Logging;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;

namespace Limbo.Subscriptions.Categories.Services {
    /// <inheritdoc/>
    public class CategoryService : CrudServiceBase<Category, ICategoryRepository>, ICategoryService {

        /// <inheritdoc/>
        public CategoryService(ICategoryRepository repository, ILogger<ServiceBase<ICategoryRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<ICategoryRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Category>> Add(Category entity) {
            Category.Vaildate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscribers(id, subscriberIds);
            }, HttpStatusCode.OK, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, dataAccessSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Category>> Update(Category entity) {
            Category.Vaildate(entity);
            return base.Update(entity);
        }
    }
}
