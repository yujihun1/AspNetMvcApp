using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Note.BLL;
using Note.MVC6.Models;

namespace Note.MVC6.Controllers
{
    public class HomeController : Controller
    {
        private readonly NoticeBll _noticeBll;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, NoticeBll noticebll)
        {
            _logger = logger;
            _noticeBll = noticebll;
        }

        public IActionResult Index()
        {
            var list = _noticeBll.GetNoticeList();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
