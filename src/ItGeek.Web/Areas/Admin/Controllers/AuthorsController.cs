using ItGeek.BLL;
using ItGeek.DAL.Entities;
using ItGeek.Web.Areas.Admin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Security.Policy;

namespace ItGeek.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class AuthorsController : Controller
{
    private readonly UnitOfWork _uow;
    private readonly IWebHostEnvironment _hostEnvironment;

    public AuthorsController(UnitOfWork uow, IWebHostEnvironment hostEnvironment)
    {
        _uow = uow;
        _hostEnvironment = hostEnvironment;
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
        ViewBag.isCreate = true;
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Author author)
    {
        if (ModelState.IsValid)
        {
            
            author.AuthorImage = await ProcessUploadFile(author);
            await _uow.AuthorRepository.InsertAsync(author);
            return RedirectToAction(nameof(Index));
        }
        ViewBag.isCreate = true;

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
        ViewBag.isCreate = false;
        return View(author);
    }
    [HttpPost]
    public async Task<IActionResult> Update(Author author)
    {
        if (ModelState.IsValid)
        {
            // Получили новую картинку 
            if (author.ImageFile != null)
            {
                string newImage = await ProcessUploadFile(author);
                author.AuthorImage = newImage;
            }

            await _uow.AuthorRepository.UpdateAsync(author);
            return RedirectToAction(nameof(Index));
        }
        ViewBag.isCreate = false;
        return View(author);
    }

    protected async Task<string> ProcessUploadFile(Author author)
    {
        string uniqueFileName = "";
        if (author.ImageFile != null)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(author.ImageFile.FileName);
            string fileExtension = Path.GetExtension(author.ImageFile.FileName);
            uniqueFileName = fileName + DateTime.Now.ToString("yymmddssfff") + fileExtension;
            string path = Path.Combine(wwwRootPath + "/uploads/", uniqueFileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                await author.ImageFile.CopyToAsync(fileStream);
            }
        }
        return uniqueFileName;
    }

}
