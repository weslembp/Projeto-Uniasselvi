using LOCADORABASE.Data;
using LOCADORABASE.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace LOCADORABASE.Controllers
{
 

        public class LocacoesController : Controller
        {
            readonly private ApplicationDbContext _db;

            public LocacoesController(ApplicationDbContext db)
            {
                _db = db;
            }

            public IActionResult Index()
            {
                IEnumerable<LocadoraModel> locadora = _db.LOCADORABASE;
                return View(locadora);
            }

            public IActionResult Cadastrar()
            {
                return View();
            }

            public IActionResult Editar(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                LocadoraModel locadora = _db.LOCADORABASE.FirstOrDefault(x => x.Id == id);

                if (locadora == null)
                {
                    return NotFound();
                }


                return View(locadora);
            }

            public IActionResult Excluir(int? id)
            {
                if (id == null || id == 0)
                {
                    return NotFound();
                }

                LocadoraModel locadora = _db.LOCADORABASE.FirstOrDefault(x => x.Id == id);

                if (locadora == null)
                {
                    return NotFound();
                }


                return View(locadora);

            }


        [HttpPost]
            public IActionResult Cadastrar(LocadoraModel locadora)
            {
                if (ModelState.IsValid)
                {
                locadora.DataEmprestimo = DateTime.Now;


                    _db.LOCADORABASE.Add(locadora);
                    _db.SaveChanges();
                    TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";

                    return RedirectToAction("Index");
                }

                return View();

            }

            [HttpPost]
            public IActionResult Editar(LocadoraModel locadora)
            {
                if (ModelState.IsValid)
                {
                    var locacoesDB = _db.LOCADORABASE.Find(locadora.Id);


                locacoesDB.FilmeEmprestado = locadora.FilmeEmprestado;
                locacoesDB.Cliente = locadora.Cliente;
               // locacoesDB.Fornecedor = locadora.Fornecedor;

                    _db.LOCADORABASE.Update(locacoesDB);
                    _db.SaveChanges();

                    TempData["MensagemSucesso"] = "Edição realizada com sucesso!";

                    return RedirectToAction("Index");
                }

                TempData["MensagemErro"] = "Ocorreu algum erro no momento da edição!";
                return View(locadora);
            }

            [HttpPost]
            public IActionResult Excluir(LocadoraModel locadora)
            {
                if (locadora == null)
                {
                    return NotFound();
                }

                _db.LOCADORABASE.Remove(locadora);
                _db.SaveChanges();
                TempData["MensagemSucesso"] = "Remoção realizada com sucesso!";
                return RedirectToAction("Index");

            }



        }
    }
