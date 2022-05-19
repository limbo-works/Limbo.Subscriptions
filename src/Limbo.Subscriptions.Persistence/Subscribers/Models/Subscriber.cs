using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;

namespace Limbo.Subscriptions.Persistence.Subscribers.Models {
    /// <summary>
    /// Represents a subscriber
    /// </summary>
    public class Subscriber : GenericId {
        /// <summary>
        /// The unique id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the subscriber
        /// </summary>
        public virtual string? Name { get; set; }

        /// <summary>
        /// The email of the subscriber
        /// </summary>
        public virtual string? Email { get; set; }

        /// <summary>
        /// Has the subscriber confirmed thier email
        /// </summary>
        public virtual bool IsConfirmed { get; set; }

        /// <summary>
        /// When was the subscriber created
        /// </summary>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// The subscription items of the subscriber
        /// </summary>
        public virtual List<SubscriptionItem> SubscriptionItems { get; set; } = new();

        /// <summary>
        /// The subscription systems of the subscriber
        /// </summary>
        public virtual SubscriptionSystem? SubscriptionSystem { get; set; }

        /// <summary>
        /// The categories of the subscriber
        /// </summary>
        public virtual List<Category> Categories { get; set; } = new();


        /// <summary>
        /// Validates if a subscriber is valid
        /// </summary>
        /// <param name="subscriber"></param>
        /// <param name="checkRelations"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Validate(Subscriber? subscriber, bool checkRelations = true) {
            if (subscriber == null) {
                throw new ArgumentException("Subscriber cannot be null", nameof(subscriber));
            }

            if (subscriber.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(subscriber));
            }

            if (subscriber.Email == null) {
                throw new ArgumentException("Email cannot be null", nameof(subscriber));
            }

            if (checkRelations) {
                subscriber.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
                subscriber.Categories?.ForEach(category => Category.Vaildate(category, false));
                SubscriptionSystem.Validate(subscriber?.SubscriptionSystem, false);
            }
        }
    }
}
