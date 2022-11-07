using BulkyBooksWeb.Data;
using BulkyBooksWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        //GET: HOME
        public IActionResult Index()
        {
            IEnumerable<Category> obj = _db.Categories;
            return View(obj);
        }

        //GET: ADD
        public IActionResult Add()
        {
            return View();
        }
    }
}
