using CollabBridge.Data;
using CollabBridge.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollabBridge.Controllers
{
    public class LoginController : Controller
    {
        readonly private ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult IndexDeslogada()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (loginModel.Login == "adm" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    if (loginModel.Login == "padrao" && loginModel.Senha == "123")
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["MessagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente.";
                    }
                return View("IndexDeslogada");
            }
            catch (Exception erro)
            {
                TempData["MessagemErro"] = $"Algo deu errado: {erro.Message}";
                return RedirectToAction("IndexDeslogada");
            }
        }
    }
}
