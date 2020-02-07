using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DostawyMaterialow.Models;

namespace DostawyMaterialow.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDostawcaRepository _dostawcaRepository;
        public HomeController(IDostawcaRepository dostawcaRepository)
        {
            _dostawcaRepository = dostawcaRepository;  
        }
        public IActionResult Index()
        {
            var materialy = _dostawcaRepository.PobierzWszystkieDostawy().OrderBy(s => s.Srednica);
            return View(materialy);

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
