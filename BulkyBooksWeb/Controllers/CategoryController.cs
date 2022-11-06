using BulkyBooksWeb.Data;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        //GET: HOME
        public IActionResult Index()
        {
            
            return View();
        }

        //GET: ADD
        public IActionResult Add()
        {
            return View();
        }
    }
}
