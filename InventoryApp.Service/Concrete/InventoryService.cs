using InventoryApp.DTO;
using InventoryApp.Repository.Contract;
using InventoryApp.Service.Contract;
using System;
using System.Linq;
using System.Web.Mvc;

namespace InventoryApp.Service.Concrete
{
    public class InventoryService : IInventoryService
    {
        private readonly IInventoryRepository inventoryRepository;

        public InventoryService(IInventoryRepository _inventoryRepository)
        {
            inventoryRepository = _inventoryRepository;
        }

        /// <summary>
        /// Delete record
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(int Id)
        {
            try
            {
                return inventoryRepository.Delete(Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns></returns>
        public IQueryable<InventoryDTO> Get()
        {
            try
            {
                return inventoryRepository.Get();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Get record by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public InventoryDTO GetById(int Id)
        {
            try
            {
                return inventoryRepository.Get(Id);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Update record
        /// </summary>
        /// <param name="inventoryDTO"></param>
        /// <returns></returns>
        public bool Patch(InventoryDTO inventoryDTO)
        {
            try
            {
                return inventoryRepository.Update(inventoryDTO.Id, inventoryDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Create new record
        /// </summary>
        /// <param name="inventoryDTO"></param>
        /// <returns></returns>
        public bool Post(InventoryDTO inventoryDTO)
        {
            try
            {
                var newId = Get().ToList().Last();
                inventoryDTO.Id = newId.Id + 1;

                return inventoryRepository.Insert(inventoryDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
