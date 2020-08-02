using Microsoft.EntityFrameworkCore;
using System;

namespace InventoryApp.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gert DB context
        /// </summary>
        /// <returns></returns>
        DbContext GetContext();

        /// <summary>
        /// Get generic repository
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TDTO"></typeparam>
        /// <returns></returns>
        IGenericRepositoryEntity<T, TDTO> GetGenericRepository<T, TDTO>() where T : class where TDTO : class;

        /// <summary>
        /// Commits the instance
        /// </summary>
        void Commit();


    }
}

