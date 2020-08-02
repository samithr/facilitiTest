using InventoryApp.Infrastructure.Interfaces;
using System;
using System.Linq;

namespace InventoryApp.Infrastructure.Concrete
{
    public class BaseService<TRepository, TEntityDTO>
        where TRepository : IBaseRepository<TEntityDTO>
        where TEntityDTO : class
    {
        public TRepository Repository;
        public IUnitOfWork UnitOfWork;

        #region Constructor
        public BaseService(IUnitOfWork unitOfWork, TRepository repository)
        {
            this.UnitOfWork = unitOfWork;
            this.Repository = repository;
        }
        #endregion

        /// <summary>
        /// Get record by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public TEntityDTO Get(object Id)
        {
            try
            {
                return Repository.Get(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get list of record
        /// </summary>
        /// <returns></returns>
        public IQueryable<TEntityDTO> Get()
        {
            try
            {
                return Repository.Get();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Insert new record
        /// </summary>
        /// <param name="entityDTO"></param>
        /// <returns></returns>
        public bool Insert(TEntityDTO entityDTO)
        {
            try
            {
                return Repository.Insert(entityDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Update entity
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="entityDTO"></param>
        /// <returns></returns>
        public bool Update(object Id, TEntityDTO entityDTO)
        {
            try
            {
                return Repository.Update(Id, entityDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Delete a record
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(object Id)
        {
            try
            {
                return Repository.Delete(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Commit changes
        /// </summary>
        public void Commit()
        {
            try
            {
                Repository.Commit();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
