using Limbo.EntityFramework.Repositories.Crud;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories {
    /// <summary>
    /// A repository for manageing subscription systems
    /// </summary>
    public interface ISubscriptionSystemRepository : IDbCrudRepositoryBase<SubscriptionSystem> {
    }
}
