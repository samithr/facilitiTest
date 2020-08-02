using InventoryApp.Database;
using InventoryApp.Infrastructure.Concrete;
using InventoryApp.Infrastructure.Interfaces;
using InventoryApp.Repository.Concrete;
using InventoryApp.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryApp.Repository
{
    public class RepositoryConfiguration
    {
        public static void ConfigureRepositories(IServiceCollection serviceCollection)
        {
            // Map entities using Automapper
            EntityMapper.Configure(serviceCollection);

            // Configure Db Context
            serviceCollection.AddScoped<DbContext, FacilitDbContext>();

            // UnitofWork configure
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            // Custom repository configuration
            serviceCollection.AddScoped<IInventoryRepository, InventoryRepository>();
            serviceCollection.AddScoped<IReOrderLevelRepository, ReOrderLevelRepository>();
        }
    }
}
