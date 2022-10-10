using MembersOfSubscription.Data;
using MembersOfSubscription.Models;
using Microsoft.AspNetCore.Mvc;

namespace MembersOfSubscription.Controllers
{
    public class FemalesController : Controller
    {
        private readonly ApplicationDbContextF _db;
        public FemalesController(ApplicationDbContextF db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var femalesList = _db.Females.ToList();
            return View(femalesList);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Female f)
        {
            if (ModelState.IsValid)
            {
                _db.Females.Add(f);
                _db.SaveChanges();
                TempData["success"] = "Person successfully added.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person addition error.";
            return View(f);
        }

        //GET
        public ActionResult Remove(int id)
        {
            Female? f = _db.Females.FirstOrDefault(f => f.Id == id);
            if (f == null)
            {
                return NotFound();
            }
            return View(f);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(Female f)
        {
            _db.Remove(f);
            _db.SaveChanges();
            TempData["success"] = "Person successfully removed.";
            return RedirectToAction("Index");
        }

        //GET
        public ActionResult Edit(int id)
        {
            Female? f = _db.Females.FirstOrDefault(f => f.Id == id);
            if (f == null)
            {
                return NotFound();
            }
            return View(f);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Female f)
        { 
            if (ModelState.IsValid)
            {
                _db.Update(f);
                _db.SaveChanges();
                TempData["success"] = "Person successfully updated.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person update error.";
            return View(f);
        }
    }
}
