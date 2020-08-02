using AutoMapper;
using AutoMapper.QueryableExtensions;
using InventoryApp.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryApp.Infrastructure.Concrete
{
    public class GenericRepositoryEntity<TEntity, TEntityDTO> : IGenericRepositoryEntity<TEntity, TEntityDTO>
        where TEntity : class
        where TEntityDTO : class
    {
        /// <summary>
        /// The context
        /// </summary>
        internal DbContext Context;

        /// <summary>
        /// The database set (entity)
        /// </summary>
        internal DbSet<TEntity> DbSet;

        #region CONSTRUCTOR 
        public GenericRepositoryEntity(DbContext _context)
        {
            /// Set the context
            Context = _context;
            /// Set the entity
            DbSet = Context.Set<TEntity>();
        }
        #endregion

        public void Delete(object ID)
        {
            try
            {
                TEntity entity = null;
                if (((ID.GetType()).BaseType).FullName == "System.Array")
                {
                    entity = DbSet.Find(((IEnumerable)ID).Cast<object>().ToArray());
                }
                else
                {
                    entity = DbSet.Find(ID);
                }
                DbSet.Remove(entity);
                Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntityDTO Get(object ID)
        {
            try
            {
                TEntity entity = null;
                if (((ID.GetType()).BaseType).FullName == "System.Array")
                {
                    entity = DbSet.Find(((IEnumerable)ID).Cast<object>().ToArray());
                }
                else
                {
                    entity = DbSet.Find(ID);
                }

                return Mapper.Map<TEntityDTO>(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<TEntityDTO> Get()
        {
            try
            {
                return DbSet.ProjectTo<TEntityDTO>();
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public bool Insert(TEntityDTO entityDTO)
        {
            try
            {
                var entityDB = DbSet.Add(Mapper.Map<TEntity>(entityDTO));
                Context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(TEntityDTO entityDTO, object ID)
        {
            try
            {
                TEntity entity = null;
                if (((ID.GetType()).BaseType).FullName == "System.Array")
                {
                    entity = DbSet.Find(((IEnumerable)ID).Cast<object>().ToArray());
                }
                else
                {
                    entity = DbSet.Find(ID);
                }

                var updatedEntity = Mapper.Map(entityDTO, entity);
                DbSet.Attach(updatedEntity);
                var entry = Context.Entry(updatedEntity);
                entry.State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
