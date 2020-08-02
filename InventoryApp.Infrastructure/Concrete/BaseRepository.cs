using AutoMapper;
using InventoryApp.Infrastructure.Interfaces;
using System.Linq;

namespace InventoryApp.Infrastructure.Concrete
{
    public abstract class BaseRepository<TEntity, TEntityDTO> : IBaseRepository<TEntityDTO>
        where TEntity : class
        where TEntityDTO : class
    {
        public readonly IUnitOfWork unitOfWork = null;

        #region Constructor

        public BaseRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion

        /// <summary>
        /// Get entity by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public TEntityDTO Get(object Id)
        {
            var entity = unitOfWork.GetGenericRepository<TEntity, TEntityDTO>().Get(Id);
            return Mapper.Map<TEntityDTO>(entity);
        }

        /// <summary>
        /// Get entity list
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntityDTO> Get()
        {
            var data = unitOfWork.GetGenericRepository<TEntity, TEntityDTO>().Get();
            return data;
        }

        /// <summary>
        /// Insert new record
        /// </summary>
        /// <param name="entityDTO"></param>
        /// <returns></returns>
        public virtual bool Insert(TEntityDTO entityDTO)
        {
            return unitOfWork.GetGenericRepository<TEntity, TEntityDTO>().Insert(entityDTO);
        }

        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Update(object Id, TEntityDTO entityDTO)
        {
            unitOfWork.GetGenericRepository<TEntity, TEntityDTO>().Update(entityDTO, Id);
            return true;
        }

        public bool Delete(object Id)
        {
            unitOfWork.GetGenericRepository<TEntity, TEntityDTO>().Delete(Id);
            return true;
        }

        /// <summary>
        /// Commit the changes
        /// </summary>
        public void Commit()
        {
            unitOfWork.Commit();
        }

        /// <summary>
        /// Dispose instance
        /// </summary>
        public void Dispose()
        {
            unitOfWork.Dispose();
        }


    }
}
