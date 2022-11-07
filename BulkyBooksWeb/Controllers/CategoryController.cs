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

        //POST: ADD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //GET: EDIT
        public IActionResult Edit(int? id)
        {
            if(id == null || id== 0)
            {
                return NotFound();
            }
            var obj = _db.Categories.Find(id);

            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST: EDIT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //GET: DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Categories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST: DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (ModelState.IsValid)
            {
                _db.Categories.Remove(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
