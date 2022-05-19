using System;
using System.Collections.Generic;
using Limbo.DataAccess.Models;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;

namespace Limbo.Subscriptions.Persistence.Categories.Models {
    /// <summary>
    /// Represents a category
    /// </summary>
    public class Category : GenericId {
        /// <summary>
        /// The unique id
        /// </summary>
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the category
        /// </summary>
        public virtual string? Name { get; set; }

        /// <summary>
        /// The subscribers of a category
        /// </summary>
        public virtual List<Subscriber> Subscribers { get; set; } = new();

        /// <summary>
        /// The subscription items of a category
        /// </summary>
        public virtual List<SubscriptionItem> SubscriptionItems { get; set; } = new();


        /// <summary>
        /// Validates if a category is valid
        /// </summary>
        /// <param name="category"></param>
        /// <param name="checkReleations"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void Vaildate(Category category, bool checkReleations = true) {
            if (category == null) {
                throw new ArgumentException("Category cannot be null", nameof(category));
            }

            if (category.Name == null) {
                throw new ArgumentException("Name cannot be null", nameof(category));
            }

            if (checkReleations) {
                category.Subscribers?.ForEach(subscriber => Subscriber.Validate(subscriber, false));
                category.SubscriptionItems?.ForEach(subscriptionItem => SubscriptionItem.Validate(subscriptionItem, false));
            }
        }
    }
}
