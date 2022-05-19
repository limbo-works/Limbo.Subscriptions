using Limbo.Subscriptions.Persistence.Extensions;
using Microsoft.Extensions.Configuration;
using Limbo.MailSystem.Extensions.Options;

namespace Limbo.Subscriptions.Extensions.Options {
    /// <summary>
    /// Options for subscriptions
    /// </summary>
    public class SubscriptionOptions {
        /// <summary>
        /// Options for GraphQL
        /// </summary>
        public GraphQLOptions GraphQLOptions { get; set; } = new();

        /// <summary>
        /// Options for subscription persistence
        /// </summary>
        public SubscriptionPersistenceOptions SubscriptionPersistenceOptions { get; set; }

        /// <summary>
        /// Options for mail system
        /// </summary>
        public MailSystemOptions MailSystemOptions { get; set; }

        /// <inheritdoc/>
        public SubscriptionOptions(IConfiguration configuration) {
            SubscriptionPersistenceOptions = new(configuration);
            MailSystemOptions = new(configuration);
        }
    }
}
