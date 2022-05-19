using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.SubscriptionItems.Models {
    /// <summary>
    /// Model for updating a subscription item
    /// </summary>
    public class SubscriptionItemUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// Subscription item node id
        /// </summary>
        [Required]
        public virtual int NodeId { get; set; }
    }
}