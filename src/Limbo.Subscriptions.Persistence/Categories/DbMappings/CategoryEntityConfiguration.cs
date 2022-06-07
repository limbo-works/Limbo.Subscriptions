using Limbo.EntityFramework.Conventions;
using Limbo.Subscriptions.Persistence.Categories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Limbo.Subscriptions.Persistence.Categories.DbMappings {
    internal class CategoryEntityConfiguration : IEntityTypeConfiguration<Category> {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.Property(p => p.Name).HasMaxLength(DefaultValues.DefaultStringLength);
        }
    }
}
