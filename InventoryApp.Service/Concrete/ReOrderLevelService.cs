using InventoryApp.Repository.Contract;
using InventoryApp.Service.Contract;

namespace InventoryApp.Service.Concrete
{
    public class ReOrderLevelService : IReOrderLevelService
    {
        private readonly IReOrderLevelRepository reOrderLevelRepository;

        public ReOrderLevelService(IReOrderLevelRepository _reOrderLevelRepository)
        {
            reOrderLevelRepository = _reOrderLevelRepository;
        }
    }
}
