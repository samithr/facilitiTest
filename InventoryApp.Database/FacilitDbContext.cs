using InventoryApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InventoryApp.Database
{
    public class FacilitDbContext : DbContext
    {
        #region Constructor

        public FacilitDbContext(DbContextOptions<FacilitDbContext> options) : base(options)
        {
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ApplyConfiguration method with reflection
            Assembly assemblyWithConfigurations = GetType().Assembly;
            builder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }

        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<ReOrderLevel> ReOrderLevel { get; set; }
    }
}
   