using ItGeek.BLL;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace ItGeek.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class AuthorsController : Controller
{
    private readonly UnitOfWork _uow;

    public AuthorsController(UnitOfWork uow)
    {
        _uow = uow;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _uow.AuthorRepository.ListAllAsync());
    }

    public async Task<IActionResult> Datails(int id)
    {
        return View(await _uow.AuthorRepository.GetByIDAsync(id));
    }

    public async Task<IActionResult> Delete(int id)
    {
        Author one = await _uow.AuthorRepository.GetByIDAsync(id);
        if (one != null)
        {
            await _uow.AuthorRepository.DeleteAsync(one);
        }
        await _uow.AuthorRepository.DeleteAsync(one);

        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Author author)
    {
        if (ModelState.IsValid)
        {
            await _uow.AuthorRepository.InsertAsync(author);
            return RedirectToAction(nameof(Index));
        }

        return View(author);
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        Author author = await _uow.AuthorRepository.GetByIDAsync(id);
        if (author != null)
        {
            return NotFound();
        }

        return View(author);
    }
    [HttpPost]
    public async Task<IActionResult> Update(Author author)
    {
        if (ModelState.IsValid)
        {
            await _uow.AuthorRepository.UpdateAsync(author);
            return RedirectToAction(nameof(Index));
        }

        return View(author);
    }

}
