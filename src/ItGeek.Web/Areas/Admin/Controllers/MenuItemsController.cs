using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ItGeek.DAL.Entities;
using ItGeek.BLL;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemsController : Controller
    {
        private readonly UnitOfWork _uow;

        public MenuItemsController(UnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _uow.MenuItemRepository.ListAllAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _uow.MenuItemRepository.GetByIDAsync(id));
        }

        public async Task<IActionResult> Delete(int id)
        {
            MenuItem menuItem = await _uow.MenuItemRepository.GetByIDAsync(id);
            if (menuItem != null)
            {
                await _uow.MenuItemRepository.DeleteAsync(menuItem);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                await _uow.MenuItemRepository.InsertAsync(menuItem);
                return RedirectToAction(nameof(Index));
            }
            return View(menuItem);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            MenuItem menuItem = await _uow.MenuItemRepository.GetByIDAsync(id);
            if (menuItem == null)
            {
                return NotFound();
            }
            return View(menuItem);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                await _uow.MenuItemRepository.UpdateAsync(menuItem);
                return RedirectToAction(nameof(Index));
            }
            return View(menuItem);
        }
    }
}
