using Dynamic_Form_Builder_Johan.Models;
using Dynamic_Form_Builder_Johan.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dynamic_Form_Builder_Johan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Create()
        {
            var viewModel = new FromVM
            {
                Fields = new List<FormFieldVM>()
            };

            return View(viewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
