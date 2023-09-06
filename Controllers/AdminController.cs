using Microsoft.AspNetCore.Mvc;
using WebApplication11.Data;
using WebApplication11.Data.Entity;

namespace WebApplication11.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyShopDataContextcs _context;
        public AdminController(MyShopDataContextcs context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return View(user);
        }
    }
}
