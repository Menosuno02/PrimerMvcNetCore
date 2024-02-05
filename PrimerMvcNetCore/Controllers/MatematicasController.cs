﻿using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace PrimerMvcNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int numero1, int numero2)
        {
            ViewData["MENSAJE"] = "La suma entre " + numero1 + " y " + numero2 + " es igual a " + (numero1 + numero2);
            return View();
        }

        public IActionResult SumarNumerosPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosPost(int numero1, int numero2)
        {
            ViewData["MENSAJE"] = "La suma entre " + numero1 + " y " + numero2 + " es igual a " + (numero1 + numero2);
            return View();
        }

        public IActionResult ConjeturaCollatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatz(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0) numero /= 2;
                else numero = numero * 3 + 1;
                numeros.Add(numero);
            }
            return View(numeros);
        }
    }
}