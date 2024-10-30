using Microsoft.AspNetCore.Mvc;
using Praktyki2024_mvc.Models;
using System.Diagnostics;

namespace Praktyki2024_mvc.Controllers
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
        public IActionResult Pojazd1()
        {
            var pojazd1 = new car1
            {
                Id = 1,
                Marka = "Mitsubishi-Fuso",
                Model = "Canter FE160",
                Rocznik = "2017",
                Typ = "Ciê¿arówka",
                Kolor = "Bia³y",
                Zdjêcie = "/images/car1.jpg",

            };

            return View(pojazd1);
        }
        public IActionResult Pojazd2()
        {
            var pojazd2 = new car2
            {
                Id = 2,
                Marka = "Honda",
                Model = "City",
                Rocznik = "2017",
                Typ = "Samochód",
                Kolor = "Czerwony",
                Zdjêcie = "/images/car2.jpg",

            };

            return View(pojazd2);
        }
        public IActionResult Pojazd3()
        {
            var pojazd3 = new car3
            {
                Id = 3,
                Marka = "Hispania",
                Model = "F112",
                Rocznik = "2012",
                Typ = "Bolid F1",
                Kolor = "Bia³y",
                Zdjêcie = "/images/car3.jpg",

            };

            return View(pojazd3);
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
