namespace Limbo.Subscriptions.Extensions.Options {
    /// <summary>
    /// Options for subscription GraphQL endpoint
    /// </summary>
    public class SubscriptionGraphQlEndpointOptions {

        /// <summary>
        /// Should use authentication and authorization
        /// </summary>
        public bool UseSecurity { get; set; } = true;

        /// <summary>
        /// Should use cors
        /// </summary>
        public bool AddCors { get; set; } = true;

    }
}
