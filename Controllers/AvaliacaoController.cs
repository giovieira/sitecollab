using Microsoft.AspNetCore.Mvc;

namespace CollabBridge.Controllers
{
    public class AvaliacaoController : Controller
    {
        public IActionResult IndexAval()
        {
            return View();
        }
    }
}
