using HotChocolate.Types;
using Limbo.Subscriptions.Bases.GraphQL.Mutations;

namespace Limbo.Subscriptions.SubscriptionSystems.Mutations {
    /// <inheritdoc/>
    [ExtendObjectType(typeof(Mutation))]
    public class SubscriptionSystemMutations : SubscriptionSystemMutationsBase {
    }
}
