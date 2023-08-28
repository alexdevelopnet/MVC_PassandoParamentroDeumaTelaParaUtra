using Microsoft.AspNetCore.Mvc;
using MVC_PassandoParamentroDeumaTelaParaUtra.Models;
using System.Diagnostics;

namespace MVC_PassandoParamentroDeumaTelaParaUtra.Controllers
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
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult AlterarSenha(string login )
        {
            ViewBag.Login = login;
            return View();
        }
        [HttpPost]
        public IActionResult AlterarSenha(Usuario usuario)
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