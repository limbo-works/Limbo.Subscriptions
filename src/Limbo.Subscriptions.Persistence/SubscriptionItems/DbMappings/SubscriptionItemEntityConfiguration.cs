using Limbo.Subscriptions.Persistence.SubscriptionItems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.SubscriptionItems.DbMappings {
    internal class SubscriptionItemEntityConfiguration : IEntityTypeConfiguration<SubscriptionItem> {
        public void Configure(EntityTypeBuilder<SubscriptionItem> builder) {
        }
    }
}
