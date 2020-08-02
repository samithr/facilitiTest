using InventoryApp.Service.Concrete;
using InventoryApp.Service.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryApp.Service
{
    public static class ServiceConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            #region App Services

            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IReOrderLevelService, ReOrderLevelService>();

            #endregion
        }
    }
}
