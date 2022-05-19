using Limbo.DataAccess.Extensions.Options;
using Limbo.Subscriptions.Persistence.Contexts.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace Limbo.Subscriptions.Persistence.Extensions {
    /// <summary>
    /// Options for subscription persistence
    /// </summary>
    public class SubscriptionPersistenceOptions {
        /// <summary>
        /// Options for the context
        /// </summary>
        public ContextOptions ContextOptions { get; set; }

        /// <summary>
        /// Options for data access
        /// </summary>
        public DataAccessOptions DataAccessOptions { get; set; }

        /// <inheritdoc/>
        public SubscriptionPersistenceOptions(IConfiguration configuration) {
            ContextOptions = new(configuration);
            DataAccessOptions = new(configuration);
        }
    }
}
