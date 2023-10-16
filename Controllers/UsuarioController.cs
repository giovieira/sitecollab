using CollabBridge.Data;
using CollabBridge.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollabBridge.Controllers
{
    public class UsuarioController : Controller
    {

        readonly private ApplicationDbContext _db;

        public UsuarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult IndexUser()
        {
            IEnumerable<UsuarioModel> usuarios = _db.Usuarios;
            return View(usuarios);
        }

        [HttpGet]
        public IActionResult CadastrarUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarUser(UsuarioModel usuarios)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Add(usuarios);
                _db.SaveChanges();

                return RedirectToAction("IndexUser");
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditarUser(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UsuarioModel usuarios = _db.Usuarios.FirstOrDefault(x => x.Id == id);

            if (usuarios == null)
            {
                return NotFound();
            }
            return View(usuarios);
        }

        [HttpPost]
        public IActionResult EditarUser(UsuarioModel usuarios)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Update(usuarios);
                _db.SaveChanges();

                return RedirectToAction("IndexUser");
            }

            return View(usuarios);
        }
        [HttpGet]
        public IActionResult ExcluirUser(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UsuarioModel usuarios = _db.Usuarios.FirstOrDefault(x => x.Id == id);

            if (usuarios == null)
            {
                return NotFound();
            }
            return View(usuarios);
        }
        [HttpPost]
        public IActionResult ExcluirUser(UsuarioModel usuarios)
        {
            if (usuarios == null)
            {
                return NotFound();
            }

            _db.Usuarios.Remove(usuarios);
            _db.SaveChanges();


            return RedirectToAction("IndexUser");
        }


    }
}