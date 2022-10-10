using MembersOfSubscription.Data;
using MembersOfSubscription.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MembersOfSubscription.Controllers
{
    public class MalesController : Controller
    {
        private readonly ApplicationDbContextM _db;
        public MalesController(ApplicationDbContextM db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var malesList = _db.Males.ToList();
            return View(malesList);
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Male m)
        {
            if (ModelState.IsValid)
            {
                _db.Males.Add(m);
                _db.SaveChanges();
                TempData["success"] = "Person successfully added.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person addition error.";
            return View(m);
        }

        //GET
        public ActionResult Remove(int id)
        {
            Male? m = _db.Males.FirstOrDefault(m => m.Id == id);
            if (m == null)
            {
                return NotFound();
            }
            return View(m);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(Male m)
        {
            _db.Remove(m);
            _db.SaveChanges();
            TempData["success"] = "Person successfully removed";
            return RedirectToAction("Index");
        }

        //GET
        public ActionResult Edit(int id)
        {
            Male? m = _db.Males.FirstOrDefault(m => m.Id == id);
            if (m == null)
            {
                return NotFound();
            }
            return View(m);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Male m)
        {
            if (ModelState.IsValid)
            {
                _db.Update(m);
                _db.SaveChanges();
                TempData["success"] = "Person successfully updated.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person update error.";
            return View(m);
        }
    }
}
