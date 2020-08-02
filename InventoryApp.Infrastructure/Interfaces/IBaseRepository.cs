using System.Linq;

namespace InventoryApp.Infrastructure.Interfaces
{
    public interface IBaseRepository<TEntityDTO> where TEntityDTO : class
    {
        TEntityDTO Get(object Id);

        IQueryable<TEntityDTO> Get();

        bool Insert(TEntityDTO entityDTO);

        bool Update(object Id, TEntityDTO entityDTO);

        bool Delete(object Id);

        void Commit();

        void Dispose();
    }
}
