using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Services;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BlogLanguageServices _langServices;

        public HomeController(ILogger<HomeController> logger, BlogLanguageServices langServices)
        {
            _logger = logger;
            _langServices = langServices;
        }

        public IActionResult Index()
        {
            
            return View(_langServices.GetAllBlogs());
        }

        public async Task<IActionResult> Detail(int id,string langCode)
        {
            var blog = _langServices.GetBlogById(id,langCode);
            return View(blog);
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