using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Areas.Data;
using WebApplication1.Areas.Logic;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ManageController : Controller
    {
        private readonly AdminDbContext _adminDbContext;
        private readonly IWebHostEnvironment _hostEnviroment;
        public ManageController(AdminDbContext adminDbContext, IWebHostEnvironment hostEnvironment)
        {
            _adminDbContext = adminDbContext;
            _hostEnviroment = hostEnvironment;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {



            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(SliderModel sliderModel)
        {

            if (ModelState.IsValid)
            {


                FileManager fileManager = new FileManager(sliderModel.ImageFile);

                string filePath = FileManager.GetImageGUIDForm()

                fileManager.SaveFile(Path.Combine(_hostEnviroment.ContentRootPath, "images", sliderModel.ImageFile.FileName), FileMode.Create); 


                _adminDbContext.Slider.Add(sliderModel);






                return View();
            }

            else
            {
                return View();
            }



        }

        
    }
}
