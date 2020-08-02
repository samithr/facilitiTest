using System.Linq;


namespace InventoryApp.Infrastructure.Interfaces
{
    public interface IBaseService<TEntityDTO> where TEntityDTO : class
    {
        TEntityDTO Get(object Id);

        IQueryable<TEntityDTO> Get();

        TEntityDTO Insert(TEntityDTO entity);

        bool Update(object Id, TEntityDTO entity);

        bool Delete(object Id);

        void Commit();
    }
}
