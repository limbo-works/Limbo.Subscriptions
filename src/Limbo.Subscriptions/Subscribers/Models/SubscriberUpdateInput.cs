using System;
using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.Subscribers.Models {
    /// <summary>
    /// Model for updating a subscriber
    /// </summary>
    public class SubscriberUpdateInput {

        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// The subscriber name
        /// </summary>
        [Required]
        public virtual string? Name { get; set; }

        /// <summary>
        /// The email of the subscriber
        /// </summary>
        [Required]
        public virtual string? Email { get; set; }

        /// <summary>
        /// Is the subscriber confirmed
        /// </summary>
        [Required]
        public virtual bool IsConfirmed { get; set; }

        /// <summary>
        /// When was the subscriber created
        /// </summary>
        [Required]
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// The id of the subscription system
        /// </summary>
        [Required]
        public virtual int SubscriptionSystemId { get; set; }
    }
}
