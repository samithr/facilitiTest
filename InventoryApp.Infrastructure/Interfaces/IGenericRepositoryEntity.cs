using System.Linq;

namespace InventoryApp.Infrastructure.Interfaces
{
    public interface IGenericRepositoryEntity<TEntity, TEntityDTO> 
        where TEntity : class
        where TEntityDTO : class
    {
        /// <summary>
        /// Gets the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        TEntityDTO Get(object ID);

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntityDTO> Get();

        /// <summary>
        /// Inserts the specified entity dto.
        /// </summary>
        /// <param name="entityDTO">The entity dto.</param>
        /// <returns></returns>
        bool Insert(TEntityDTO entityDTO);

        /// <summary>
        /// Updates the specified entity dto.
        /// </summary>
        /// <param name="entityDTO">The entity dto.</param>
        /// <param name="ID">The identifier.</param>
        void Update(TEntityDTO entityDTO, object ID);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        void Delete(object ID);

    }
}
