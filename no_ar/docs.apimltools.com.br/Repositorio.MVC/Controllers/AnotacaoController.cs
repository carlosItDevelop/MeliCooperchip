using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class AnotacaoController : Controller
    {
        // Troca o contexto
        //private BancoContexto db = new BancoContexto();
        private readonly AnotacaoRepositorio _reppositorio = new AnotacaoRepositorio();

        // GET: /Clientes/
        public ActionResult Index() {
            //return View(db.Cliente.ToList());
            return View(_reppositorio.GetAll().ToList());
        }

        // GET: /Clientes/Details/5
        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Cliente.Find(id);
            Anotacao anotacao = _reppositorio.Find(id);

            if(anotacao == null) {
                return HttpNotFound();
            }
            return View(anotacao);
        }

        // GET: /Anotacoes/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Anotacaoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnotacaoID,Tags,Titulo,Descricao,DataAnotacao,Status")] Anotacao anotacao) {
            if(ModelState.IsValid) {
                //db.Cliente.Add(cliente);
                _reppositorio.Adicionar(anotacao);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(anotacao);
        }

        // GET: /Aotacoes/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Anotacao anotacao = _reppositorio.Find(id);
            if(anotacao == null) {
                return HttpNotFound();
            }
            return View(anotacao);
        }

        // POST: Anotacaoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnotacaoID,Tags,Titulo,Descricao,DataAnotacao,Status")] Anotacao anotacao) {
            if(ModelState.IsValid) {
                //db.Entry(cliente).State = EntityState.Modified;
                _reppositorio.Atualizar(anotacao);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(anotacao);
        }

        // GET: /Anotacoes/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Anotacao anotacao = _reppositorio.Find(id);
            if(anotacao == null) {
                return HttpNotFound();
            }
            return View(anotacao);
        }

        // POST: /Anotacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            Anotacao anotacao = _reppositorio.Find(id);


            _reppositorio.Excluir(c => c == anotacao);


            _reppositorio.SalvarTodos();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {

            _reppositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
