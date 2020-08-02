using InventoryApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryApp.Database.Configuration
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(Inventory.NameMaxLength);
            builder.Property(p => p.Description)
                .HasMaxLength(Inventory.DescriptionMaxLength);
            builder.Property(p => p.AvailableUnits)
                .HasMaxLength(Inventory.UnitsMaxLenght);
        }
    }
}
