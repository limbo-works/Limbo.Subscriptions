using System.Data;
using System.Net;
using System.Threading.Tasks;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.Categories.Repositories;
using Microsoft.Extensions.Logging;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;

namespace Limbo.Subscriptions.Categories.Services {
    /// <inheritdoc/>
    public class CategoryService : CrudServiceBase<Category, ICategoryRepository>, ICategoryService {

        /// <inheritdoc/>
        public CategoryService(ICategoryRepository repository, ILogger<ServiceBase<ICategoryRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<ICategoryRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Category>> Add(Category entity) {
            Category.Vaildate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> AddSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddSubscribers(id, subscriberIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> AddSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.AddSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.Created, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> RemoveSubscribers(int id, int[] subscriberIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveSubscribers(id, subscriberIds);
            }, HttpStatusCode.OK, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public virtual async Task<IServiceResponse<Category>> RemoveSubscriptionItems(int id, int[] subscriptionItemIds) {
            return await ExecuteServiceTask(async () => {
                return await Repository.RemoveSubscriptionItems(id, subscriptionItemIds);
            }, HttpStatusCode.OK, EntityFrameworkSettings.DefaultIsolationLevel);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<Category>> Update(Category entity) {
            Category.Vaildate(entity);
            return base.Update(entity);
        }
    }
}
