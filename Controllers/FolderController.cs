using FolderProject.Data;
using FolderProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FolderProject.Controllers
{
    public class FolderController : Controller
    {
        private readonly AppDbContext dbContext;

        public FolderController(AppDbContext db)
        {
            dbContext = db;
        }


        [HttpGet]
        public IActionResult Index(int? id)
        {
            IndexViewModel indexViewModel = new IndexViewModel()
            {
                ParentName = dbContext.Folders.Find(id)?.Name
            };

            if (id == null)
            {
                indexViewModel.folders = dbContext.Folders.ToList();
            }
            else
            {
                indexViewModel.folders = dbContext.Folders.ToList().FindAll(i => i.ParentId == id);
            }

            return View(indexViewModel);
        }
    }
}
