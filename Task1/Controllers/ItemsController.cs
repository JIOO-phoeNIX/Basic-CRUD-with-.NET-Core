using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task1.DataAccess.Models;
using Task1.DataAccess.Repository;

namespace Task1.Controllers
{     
    public class ItemsController : Controller
    {
        private readonly ItemsRepository itemsRepository;
        
        public ItemsController(ItemsRepository itemsRepository)
        {
            this.itemsRepository = itemsRepository;
        }

        public IActionResult Index()
        {
            var allItems = itemsRepository.GetAll();
            return View(allItems);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind(include: "Title, Description, UnitType, Rate")] Items item)
        {
            if (ModelState.IsValid)
            {
                item.DateCreated = DateTime.Now;
                await itemsRepository.Create(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var itemToEdit = await itemsRepository.Get(id);

            if (itemToEdit == null)
            {
                return RedirectToAction("Index");
            }

            return View(itemToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Items item)
        {
            if (ModelState.IsValid)
            {
                await itemsRepository.Edit(item);
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            var itemToDelete = await itemsRepository.Get(id);

            if (itemToDelete == null)
            {
                return RedirectToAction("Index");
            }

            return View(itemToDelete);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Items item)
        {
            await itemsRepository.Delete(item);
            return RedirectToAction("Index");
        }        
    }
}
