using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.SubscriptionSystems.Models {
    /// <summary>
    /// Model for updating a subscription system
    /// </summary>
    public class SubscriptionSystemUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// Subscription system name
        /// </summary>
        [Required]
        public virtual string? Name { get; set; }
    }
}