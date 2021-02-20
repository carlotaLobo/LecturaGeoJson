using LecturaGeoJson.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LecturaGeoJson.Controllers
{
    public class HomeController : Controller
    {
        MapRepository mapRepository;
        public HomeController(MapRepository mapRepository)
        {
            this.mapRepository = mapRepository;
        }
        public IActionResult Index()
        {
            return View(this.mapRepository.GetGeoJson());
        }
    }
}
