using GetHelp.Data;
using GetHelp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GetHelp.Controllers
{
    public class ProblemController : Controller
    {


         private readonly ApplicationDbContext _db;

        public ProblemController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Problem> objProblemList = _db.Problem.ToList();
            return View(objProblemList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Problem obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            //}

            if (ModelState.IsValid)
            {
                _db.Problem.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();

        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Problem? categoryFromDb = _db.Problem.FirstOrDefault(u => u.Id == id);
            // Category? categoryFromDb = _db.Category.Get(u => u.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Problem obj)
        {
            if (ModelState.IsValid)
            {
                _db.Problem.Update(obj);
                _db.SaveChanges();

                //_db.Category.Update(obj);
                // _db.Save();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }





        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Problem? categoryFromDb = _db.Problem.FirstOrDefault(u => u.Id == id);
            // Category? categoryFromDb = _db.Category.Get(u => u.Id == id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int id)
        {
            Problem? obj = _db.Problem.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            _db.Problem.Remove(obj);
            _db.SaveChanges();

            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
