using BulkyApp.Data;
using BulkyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyApp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}
