using InventoryApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryApp.Database.Configuration
{
    public class ReOrderLevelConfiguration : IEntityTypeConfiguration<ReOrderLevel>
    {
        public void Configure(EntityTypeBuilder<ReOrderLevel> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(ReOrderLevel.NameMaxLength);
            builder.Property(p => p.Description)
                .HasMaxLength(ReOrderLevel.DescriptionMaxLength);
        }
    }
}
