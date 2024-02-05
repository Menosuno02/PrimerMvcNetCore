using Microsoft.AspNetCore.Mvc;
using PrimerMvcNetCore.Models;

namespace PrimerMvcNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            // Vamos a enviar información simple a nuestra vista
            ViewData["NOMBRE"] = "Alumno";
            ViewData["EDAD"] = 24;
            ViewBag.DiaSemana = "Lunes";
            ViewData["DIASEMANA"] = "Mañana martes";
            Persona persona = new Persona();
            persona.Nombre = "Persona Model";
            persona.Email = "model@gmail.com";
            persona.Edad = 77;
            return View(persona);
        }

        public IActionResult VistaControladorGet(string app, System.Nullable<int> version)
        {
            if (version is null)
            {
            }
            // Dibujamos en la vista los parámetros recibidos
            ViewData["DATOS"] = "Application: " + app + ", version: " + version.GetValueOrDefault();
            return View();
        }

        public IActionResult VistaControladorPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControladorPost(Persona persona, string aficiones)
        {
            ViewData["DATOS"] = "Nombre: " + persona.Nombre + ", email: " + persona.Email + ", edad: " + persona.Edad + ", aficiones: " + aficiones;
            return View();
        }
    }
}