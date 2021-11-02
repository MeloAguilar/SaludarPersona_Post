using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SaludarPersona_Post_UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SaludarPersona_Post_Entities;

namespace SaludarPersona_Post_UI.Controllers
{
    public class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string _nombre, string _apellidos)
        {
            ViewBag.Nombre = _nombre;
            ViewBag.Apellidos = _apellidos;
            return View("Saludar");
        }

    }
}
