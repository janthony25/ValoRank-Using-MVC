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
            IEnumerable<Member> members = _db.Members;

            return View(members);
        }
    }
}
