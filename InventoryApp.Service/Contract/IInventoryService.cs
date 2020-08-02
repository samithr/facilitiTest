using InventoryApp.DTO;
using InventoryApp.Infrastructure.Interfaces;
using System.Linq;

namespace InventoryApp.Service.Contract
{
    public interface IInventoryService
    {
        IQueryable<InventoryDTO> Get();
        InventoryDTO GetById(int Id);
        bool Post(InventoryDTO inventoryDTO);
        bool Patch(InventoryDTO inventoryDTO);
        bool Delete(int Id);
    }
}
