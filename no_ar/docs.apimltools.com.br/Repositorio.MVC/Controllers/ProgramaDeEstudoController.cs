using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProgramaDeEstudoController : Controller
    {
        // Troca o contexto
        //private BancoContexto db = new BancoContexto();
        private readonly ProgramaDeEstudoRepositorio _reppositorio = new ProgramaDeEstudoRepositorio();

        // GET: ProgramaDeEstudo
        public ActionResult Index() {
            //return View(db.Cliente.ToList());
            return View(_reppositorio.GetAll().ToList());
        }

        // GET: ProgramaDeEstudo/Details/5
        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Cliente.Find(id);
            ProgramaDeEstudo programadeestudo = _reppositorio.Find(id);

            if(programadeestudo == null) {
                return HttpNotFound();
            }
            return View(programadeestudo);
        }

        // GET: ProgramaDeEstudo/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ProgramaDeEstudo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProgramaDeEstudoID,Titulo,Descricao,Iniciado,Entendido,Praticado")] ProgramaDeEstudo programadeestudo) {
            if(ModelState.IsValid) {
                //db.Cliente.Add(cliente);
                _reppositorio.Adicionar(programadeestudo);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(programadeestudo);
        }

        // GET: ProgramaDeEstudo/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProgramaDeEstudo programadeestudo = _reppositorio.Find(id);
            if(programadeestudo == null) {
                return HttpNotFound();
            }
            return View(programadeestudo);
        }

        // POST: ProgramaDeEstudo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProgramaDeEstudoID,Titulo,Descricao,Iniciado,Entendido,Praticado")] ProgramaDeEstudo programadeestudo) {
            if(ModelState.IsValid) {

                _reppositorio.Atualizar(programadeestudo);


                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(programadeestudo);
        }

        // GET: ProgramaDeEstudo/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProgramaDeEstudo programadeestudo = _reppositorio.Find(id);
            if(programadeestudo == null) {
                return HttpNotFound();
            }
            return View(programadeestudo);
        }

        // POST: ProgramaDeEstudo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            ProgramaDeEstudo programadeestudo = _reppositorio.Find(id);


            _reppositorio.Excluir(c => c == programadeestudo);


            _reppositorio.SalvarTodos();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {

            _reppositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
