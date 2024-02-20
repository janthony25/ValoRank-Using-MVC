using Microsoft.AspNetCore.Mvc;
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
            return RedirectToAction("Index");
        }
    }
}
