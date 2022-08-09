using Calculadora.DAO;
using Calculadora.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {
        private readonly IcalculadoraDAO _calculadoraDAO;

        public HomeController(IcalculadoraDAO calculadoraDAO)
        {
            _calculadoraDAO = calculadoraDAO;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(CalculadoraModel calculadora)
        {
            _calculadoraDAO.Adicionar(calculadora);
            return View(calculadora);
        }
    }
}
