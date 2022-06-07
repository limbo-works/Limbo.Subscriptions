using System.Threading.Tasks;
using Limbo.EntityFramework.Services;
using Limbo.EntityFramework.Services.Crud;
using Limbo.EntityFramework.Services.Models;
using Limbo.EntityFramework.Settings;
using Limbo.EntityFramework.UnitOfWorks;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.SubscriptionSystems.Services {

    /// <inheritdoc/>
    public class SubscriptionSystemService : CrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository>, ISubscriptionSystemService {

        /// <inheritdoc/>
        public SubscriptionSystemService(ISubscriptionSystemRepository repository, ILogger<ServiceBase<ISubscriptionSystemRepository>> logger, EntityFrameworkSettings entityFrameworkSettings, IUnitOfWork<ISubscriptionSystemRepository> unitOfWork) : base(repository, logger, entityFrameworkSettings, unitOfWork) {
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<SubscriptionSystem>> Add(SubscriptionSystem entity) {
            SubscriptionSystem.Validate(entity);
            return base.Add(entity);
        }

        /// <inheritdoc/>
        public override Task<IServiceResponse<SubscriptionSystem>> Update(SubscriptionSystem entity) {
            SubscriptionSystem.Validate(entity);
            return base.Update(entity);
        }
    }
}
