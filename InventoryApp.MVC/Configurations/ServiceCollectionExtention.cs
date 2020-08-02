using InventoryApp.Database;
using InventoryApp.Repository;
using InventoryApp.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryApp.MVC.Configurations
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region DB Congfig
            services.AddDbContext<FacilitDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
            //services.AddDbContext<FacilitDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Server=172.20.1.177;Database=FacilitTest;User ID=dev;Password=B1ost@rR3@der;Trusted_Connection=False;")));
            #endregion

            #region Services

            ServiceConfiguration.Configure(services);

            #endregion

            #region Repositories

            RepositoryConfiguration.ConfigureRepositories(services);

            #endregion

            return services;
        }
    }
}
