using System.Threading.Tasks;
using Limbo.DataAccess.Services;
using Limbo.DataAccess.Services.Crud;
using Limbo.DataAccess.Services.Models;
using Limbo.DataAccess.Settings;
using Limbo.DataAccess.UnitOfWorks;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.SubscriptionSystems.Services {

    /// <inheritdoc/>
    public class SubscriptionSystemService : CrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository>, ISubscriptionSystemService {

        /// <inheritdoc/>
        public SubscriptionSystemService(ISubscriptionSystemRepository repository, ILogger<ServiceBase<ISubscriptionSystemRepository>> logger, DataAccessSettings dataAccessSettings, IUnitOfWork<ISubscriptionSystemRepository> unitOfWork) : base(repository, logger, dataAccessSettings, unitOfWork) {
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
