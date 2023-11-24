using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication1.Areas.Admin.Data;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Helpers;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdminDbContext _context;
        private readonly IWebHostEnvironment _env;

        public HomeController(AdminDbContext context, IWebHostEnvironment env)
        {
            _env = env;
            _context = context;
        }

        public IActionResult Index()
        {
            List<SliderModel> models = _context.Slider.ToList();

            foreach(SliderModel model in models)
            {
                model.ImagePath = Utils.ConvertAbsToURI(_env.WebRootPath, model.ImagePath);
            }
            return View(models);
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