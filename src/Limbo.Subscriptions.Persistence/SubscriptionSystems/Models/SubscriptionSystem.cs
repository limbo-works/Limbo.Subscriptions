using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.Models {
    /// <summary>
    /// Represents a subscription system
    /// </summary>
    public class SubscriptionSystem : GenericId {
        /// <summary>
        /// The unique id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the system
        /// </summary>
        public virtual string? Name { get; set; }

        /// <summary>
        /// The subscribers in the system
        /// </summary>
        public virtual List<Subscriber> Subscribers { get; set; } = new();

        /// <summary>
        /// Validates that the subscription system is valid
        /// </summary>
        /// <param name="subscriptionSystem"></param>
        /// <param name="checkRelations"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Validate(SubscriptionSystem? subscriptionSystem, bool checkRelations = true) {
            if (subscriptionSystem == null) {
                throw new ArgumentException("SubscriptionSystem cannot be null", nameof(subscriptionSystem));
            }

            if (checkRelations) {
                subscriptionSystem.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
            }
        }
    }
}
