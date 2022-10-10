using MembersOfSubscription.Data;
using MembersOfSubscription.Models;
using Microsoft.AspNetCore.Mvc;

namespace MembersOfSubscription.Controllers
{
    public class OthersController : Controller
    {
        private readonly ApplicationDbContextO _db;
        public OthersController(ApplicationDbContextO db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var othersList = _db.Others.ToList();
            return View(othersList);
        }

        //GET
        public ActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Other o)
        {
            if (ModelState.IsValid)
            {
                _db.Others.Add(o);
                _db.SaveChanges();
                TempData["success"] = "Person successfully added.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person addition error.";
            return View(o);
        }

        //GET
        public ActionResult Remove(int id)
        {
            Other? o = _db.Others.FirstOrDefault(o => o.Id == id);
            if (o == null)
            {
                return NotFound();
            }
            return View(o);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(Other o)
        {
            _db.Remove(o);
            _db.SaveChanges();
            TempData["success"] = "Person successfully removed.";
            return RedirectToAction("Index");
        }

        //GET
        public ActionResult Edit(int id)
        {
            Other? o = _db.Others.FirstOrDefault(o => o.Id == id);
            if (o == null)
            {
                return NotFound();
            }
            return View(o);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Other o)
        {
            if (ModelState.IsValid)
            {
                _db.Update(o);
                _db.SaveChanges();
                TempData["success"] = "Person successfully updated.";
                return RedirectToAction("Index");
            }
            TempData["error"] = "Person update error.";
            return View(o);
        }
    }
}