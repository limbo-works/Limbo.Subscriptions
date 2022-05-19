using Limbo.DataAccess.Contexts.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.NewsletterQueues.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo.Subscriptions.Persistence.Contexts {
    /// <summary>
    /// Represents a context for interacting with the database
    /// </summary>
    public interface ISubscriptionDbContext : IDbContext {
        /// <summary>
        /// Categories
        /// </summary>
        DbSet<Category>? Categories { get; set; }

        /// <summary>
        /// Newsletter queues
        /// </summary>
        DbSet<NewsletterQueue>? NewsletterQueues { get; set; }

        /// <summary>
        /// Subscribers
        /// </summary>
        DbSet<Subscriber>? Subscribers { get; set; }

        /// <summary>
        /// Subscription items
        /// </summary>
        DbSet<SubscriptionItem>? SubscriptionItems { get; set; }

        /// <summary>
        /// Subscription systems
        /// </summary>
        DbSet<SubscriptionSystem>? SubscriptionSystems { get; set; }
    }
}