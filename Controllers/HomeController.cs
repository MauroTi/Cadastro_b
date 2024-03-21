using Cadastro_b.Models;
using Cadastro_b.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cadastro_b.Controllers
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
       
        public IActionResult Resultados(string nome,string endereco, string telefone)
        {

            string dadosFormatados = ServiceFormat.FormatData(nome, endereco, telefone);

            ViewBag.DadosFormatados = dadosFormatados;
            return View();
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
