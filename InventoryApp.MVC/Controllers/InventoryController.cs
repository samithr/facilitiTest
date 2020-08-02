using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.DTO;
using InventoryApp.Service.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.MVC.Controllers
{
    [Authorize]
    public class InventoryController : Controller
    {
        private readonly IInventoryService inventoryService;

        #region Constructor
        public InventoryController(IInventoryService _inventoryService)
        {
            inventoryService = _inventoryService;
        }
        #endregion


        public IActionResult Index()
        {
            var data = inventoryService.Get().ToList();
            return View(data);
        }

        // Return view for Create
        public IActionResult Create()
        {
            return View("Create");
        }

        // Return view for edit
        [Route("Inventory/CreateOrEdit/{Id}")]
        public IActionResult CreateOrEdit(int Id)
        {
            // check for update method
            if (Id > 0)
            {
                var recordData = inventoryService.GetById(Id);
                return View("Create", recordData);
            }
            return View("Create");
        }

        // Save changes
        [HttpPost]
        [Route("CreateOrEdit")]
        public IActionResult CreateOrUpdate(InventoryDTO inventoryDTO)
        {
            // If update send for update
            if (inventoryDTO.Id > 0)
            {
                inventoryService.Patch(inventoryDTO);
                return RedirectToAction("Index");
            }

            // create new entry
            var data = inventoryService.Post(inventoryDTO);
            return RedirectToAction("Index");
        }

        // Delete record
        [Route("Delete")]
        public IActionResult Delete(int Id)
        {
            inventoryService.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
