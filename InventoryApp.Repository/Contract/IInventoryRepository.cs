using InventoryApp.DTO;
using InventoryApp.Infrastructure.Interfaces;

namespace InventoryApp.Repository.Contract
{
    public interface IInventoryRepository : IBaseRepository<InventoryDTO>
    {
    }
}
