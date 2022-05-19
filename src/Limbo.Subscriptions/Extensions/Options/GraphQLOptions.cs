using System;
using HotChocolate.Execution.Configuration;

namespace Limbo.Subscriptions.Extensions.Options {
    /// <summary>
    /// Options for GraphQL
    /// </summary>
    public class GraphQLOptions {
        /// <summary>
        /// Extensions to the GraphQL pipeline
        /// </summary>
        public Func<IRequestExecutorBuilder, IRequestExecutorBuilder>? GraphQLExtensions { get; set; } = null;
    }
}