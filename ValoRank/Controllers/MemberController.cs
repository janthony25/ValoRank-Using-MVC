﻿using Microsoft.AspNetCore.Mvc;
using ValoRank.Data;
using ValoRank.Models;

namespace ValoRank.Controllers
{
    public class MemberController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MemberController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Member> obj = _db.Members;

            return View(obj);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member obj)
        {
            _db.Members.Add(obj);
            _db.SaveChanges();
            TempData["success"] = "Member added successfully";
            return RedirectToAction("Index");
        }

        // GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Members.Find(id);
            return View(obj);
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Member obj)
        {
            _db.Members.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Member edited successfully";
            return RedirectToAction("Index");
        }

        // GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Members.Find(id);
            return View(obj);
        }

        // POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Members.Find(id);
            if(obj == null)
            {
                return NotFound(id);
            }

            _db.Members.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Member has been removed";
            return RedirectToAction("Index");
        }


    }
}
