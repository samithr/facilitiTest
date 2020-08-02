using InventoryApp.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;

namespace InventoryApp.Infrastructure.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        private DbContext DbContext;
        private Hashtable Repositories;
        private bool disposed = false;
        private readonly object lockObject = new object();
        private readonly object lockDTO = new object();
        #endregion

        #region Constructor

        public UnitOfWork(DbContext _context)
        {
            DbContext = _context;
        }

        #endregion

        /// <summary>
        /// Gets the DbContext
        /// </summary>
        /// <returns></returns>
        public DbContext GetContext()
        {
            return DbContext;
        }

        /// <summary>
        /// Gets the repository with DTO.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TDTO">The type of the dto.</typeparam>
        /// <returns></returns>
        public IGenericRepositoryEntity<T, TDTO> GetGenericRepository<T, TDTO>()
            where T : class
            where TDTO : class
        {
            var typeName = String.Format("{0}_{1}", typeof(T).Name, typeof(TDTO).Name);
            lock (lockObject)
            {
                if (Repositories == null)
                    Repositories = new Hashtable();

                if (!Repositories.ContainsKey(typeName))
                {
                    var repositoryType = typeof(GenericRepositoryEntity<,>);
                    var repositoryInstance =
                        Activator.CreateInstance(repositoryType
                                .MakeGenericType(typeof(T), typeof(TDTO)), DbContext);

                    Repositories.Add(typeName, repositoryInstance);
                }
            }

            return (IGenericRepositoryEntity<T, TDTO>)Repositories[typeName];
        }


        /// <summary>
        /// Commit this intance
        /// </summary>
        public void Commit()
        {
            DbContext.SaveChanges();
        }

        /// <summary>
        /// Application defined task clearing
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releasung  unmanaged, optionally managed resources
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DbContext.Dispose();
                    DbContext = null;
                    this.disposed = true;
                }

                this.Repositories = null;
            }
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
