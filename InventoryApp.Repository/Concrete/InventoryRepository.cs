using InventoryApp.Database.Models;
using InventoryApp.DTO;
using InventoryApp.Infrastructure.Concrete;
using InventoryApp.Infrastructure.Interfaces;
using InventoryApp.Repository.Contract;

namespace InventoryApp.Repository.Concrete
{
    public class InventoryRepository : BaseRepository<Inventory, InventoryDTO>, IInventoryRepository
    {
        public InventoryRepository(IUnitOfWork _unitOfWork) : base(_unitOfWork)
        {

        }
    }
}
