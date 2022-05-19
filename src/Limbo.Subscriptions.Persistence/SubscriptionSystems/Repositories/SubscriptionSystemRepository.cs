using Limbo.DataAccess.Repositories.Crud;
using Limbo.Subscriptions.Persistence.Contexts;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories {

    /// <inheritdoc/>
    public class SubscriptionSystemRepository : DbCrudRepositoryBase<SubscriptionSystem>, ISubscriptionSystemRepository {
        /// <inheritdoc/>
        public SubscriptionSystemRepository(IDbContextFactory<SubscriptionDbContext> contextFactory, ILogger<DbCrudRepositoryBase<SubscriptionSystem>> logger) : base(contextFactory, logger) {
        }
    }
}
