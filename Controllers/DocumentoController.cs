using CollabBridge.Data;
using CollabBridge.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollabBridge.Controllers
{
    public class DocumentoController : Controller
    {

        readonly private ApplicationDbContext _db;

        public DocumentoController(ApplicationDbContext db)
        {
                _db = db;
        }

        public IActionResult IndexDoc()
        {
            IEnumerable<DocumentosModel> documentos = _db.Documentos;
            return View(documentos);
        }
        [HttpGet]
        public IActionResult CadastrarDoc() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CadastrarDoc(DocumentosModel documentos)
        {
            if(ModelState.IsValid)
            {
                _db.Documentos.Add(documentos);
                _db.SaveChanges();

                return RedirectToAction("IndexDoc");
            }

            return View();
        }

        [HttpGet]
        public IActionResult EditarDoc(int? id)
        {
            if(id == null || id == 0) 
            {
                return NotFound();
            }

            DocumentosModel documento = _db.Documentos.FirstOrDefault(x => x.Id == id);

            if(documento == null) 
            {
                return NotFound();
            }
            return View(documento); 
        }

        [HttpPost]
        public IActionResult EditarDoc(DocumentosModel documento) 
        {
            if(ModelState.IsValid) 
            {
                _db.Documentos.Update(documento);
                _db.SaveChanges();

                return RedirectToAction("IndexDoc");
            }

            return View(documento);
        }
        [HttpGet]
        public IActionResult ExcluirDoc(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DocumentosModel documento = _db.Documentos.FirstOrDefault(x => x.Id == id);

            if (documento == null)
            {
                return NotFound();
            }
            return View(documento);
        }
        [HttpPost]
        public IActionResult ExcluirDoc(DocumentosModel documento) 
        {
            if (documento == null) 
            {
                return NotFound();
            }
            
            _db.Documentos.Remove(documento);
            _db.SaveChanges();

            return RedirectToAction("IndexDoc");
        }


    }
}
