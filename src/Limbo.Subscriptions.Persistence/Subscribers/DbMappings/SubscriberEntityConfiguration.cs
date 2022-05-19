using Limbo.DataAccess.Conventions;
using Limbo.Subscriptions.Persistence.Subscribers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.Subscribers.DbMappings {
    internal class SubscriberEntityConfiguration : IEntityTypeConfiguration<Subscriber> {
        public void Configure(EntityTypeBuilder<Subscriber> builder) {
            builder.Property(p => p.Name).HasMaxLength(DefaultValues.DefaultStringLength);

            builder.Property(p => p.Email).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
