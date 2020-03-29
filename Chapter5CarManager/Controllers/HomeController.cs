using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Chapter5CarManager.Models;
using VehicleLibrary;

namespace Chapter5CarManager.Controllers
{
    public class HomeController : Controller
    {
        private VehicleRepository _vehRepo = new VehicleRepository();
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
            var myCar = new Car
            {
                Year = 2015,
                Make = "Toyota",
                Model = "Camry",
                NumberOfDoors = 4
            };

            _vehRepo.Add(myCar);
            
            return View(myCar);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
