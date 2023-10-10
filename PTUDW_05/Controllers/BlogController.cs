using Microsoft.AspNetCore.Mvc;
using PTUDW_05.Models;

namespace PTUDW_05.Controllers
{
    public class BlogController : Controller
    {
        private readonly HarmicContext _context;

        public BlogController(HarmicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
