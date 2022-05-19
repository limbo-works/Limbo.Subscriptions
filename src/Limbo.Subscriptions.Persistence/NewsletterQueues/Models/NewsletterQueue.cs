using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.NewsletterQueues.Models {
    /// <summary>
    /// Represents a newsletter queue
    /// </summary>
    public class NewsletterQueue : GenericId {
        /// <summary>
        /// The unique id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the newsletter queue
        /// </summary>
        public virtual string? Name { get; set; }

        /// <summary>
        /// The subscription items of a newsletter queue
        /// </summary>
        public virtual List<SubscriptionItem> SubscriptionItems { get; set; } = new();

        /// <summary>
        /// Validates if a newsletter queue is valid
        /// </summary>
        /// <param name="newsletterQueue"></param>
        /// <param name="checkRelations"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Validate(NewsletterQueue? newsletterQueue, bool checkRelations = true) {
            if (newsletterQueue == null) {
                throw new ArgumentException("NewsletterQueue cannot be null", nameof(newsletterQueue));
            }

            if (newsletterQueue.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(newsletterQueue));
            }

            if (checkRelations) {
                newsletterQueue.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
            }
        }
    }
}
