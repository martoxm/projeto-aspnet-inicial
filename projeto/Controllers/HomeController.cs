using Microsoft.AspNetCore.Mvc;

namespace projeto_aspnet_inicial.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Mensagem = "Meu primeiro projeto ASP.NET!";
            return View();
        }
    }
}