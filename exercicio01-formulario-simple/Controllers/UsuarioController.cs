using Microsoft.AspNetCore.Mvc;
using exercicio01_formulario_simple.Models;

namespace exercicio01_formulario_simple.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Usuario usuario)
        {
            return View("Resultado", usuario);
        }
    }
}