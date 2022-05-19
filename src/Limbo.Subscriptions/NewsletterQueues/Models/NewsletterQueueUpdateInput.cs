using System.ComponentModel.DataAnnotations;

namespace Limbo.Subscriptions.NewsletterQueues.Models {
    /// <summary>
    /// Model for updating a newsletter queue
    /// </summary>
    public class NewsletterQueueUpdateInput {
        /// <summary>
        /// Id
        /// </summary>
        [Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// The name of the newsletter queue
        /// </summary>
        [Required]
        public virtual string? Name { get; set; }
    }
}