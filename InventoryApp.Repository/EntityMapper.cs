using AutoMapper;
using InventoryApp.Database.Models;
using InventoryApp.DTO;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryApp.Repository
{
    public class EntityMapper
    {
        public static void Configure(IServiceCollection services)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Inventory, InventoryDTO>();
                cfg.CreateMap<ReOrderLevel, ReOrderLevelDTO>();
            });
        }
    }
}
