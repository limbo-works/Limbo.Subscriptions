using Limbo.EntityFramework.Conventions;
using Limbo.Subscriptions.Persistence.SubscriptionSystems.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.SubscriptionSystems.DbMappings {
    internal class SubscriptionSystemEntityConfiguration : IEntityTypeConfiguration<SubscriptionSystem> {
        public void Configure(EntityTypeBuilder<SubscriptionSystem> builder) {
            builder.Property(p => p.Name).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
