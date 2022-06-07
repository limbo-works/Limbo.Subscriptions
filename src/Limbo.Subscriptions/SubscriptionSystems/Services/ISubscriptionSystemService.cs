using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Repositories;
using Limbo.EntityFramework.Services.Crud;

namespace Limbo.Subscriptions.SubscriptionSystems.Services {
    /// <summary>
    /// A service for managing subscription systems
    /// </summary>
    public interface ISubscriptionSystemService : ICrudServiceBase<SubscriptionSystem, ISubscriptionSystemRepository> {
    }
}