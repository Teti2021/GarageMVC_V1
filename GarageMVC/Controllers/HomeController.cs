using GarageMVC.Models;
using GarajeMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GarageMVC.Controllers
{
    public class HomeController : Controller
    {
        // Instancia del garaje
        Garage miGaraje = new Garage(
            1,
            "Ruth Ester Moradel Leiva",
            10,
            0
        );

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Auto auto1 = new Auto(1, "Toyota", "HCP1077");
            Auto auto2 = new Auto(2, "Honda", "HCB2345");
            Auto auto3 = new Auto(3, "Mitsubishi", "HDP2010");

            miGaraje.ingresarAuto(auto1);
            miGaraje.ingresarAuto(auto2);
            miGaraje.ingresarAuto(auto3);

            return View(miGaraje);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
