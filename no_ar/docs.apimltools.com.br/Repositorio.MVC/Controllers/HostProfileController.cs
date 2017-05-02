using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
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
    public class HostProfileController : Controller
    {
        // Troca o contexto
        //private BancoContexto db = new BancoContexto();
        private readonly HostProfileRepositorio _reppositorio = new HostProfileRepositorio();

        // GET: Hostprofile
        public ActionResult Index() {
            //return View(db.Hostprofile.ToList());
            return View(_reppositorio.GetAll().ToList());
        }


        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            HostProfile profile = _reppositorio.Find(id);

            if(profile == null) {
                return HttpNotFound();
            }
            return View(profile);
        }

        // GET: HostProfile/Create
        public ActionResult Create() {
            return View();
        }

        // POST: HostProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HostProfileID,TipoDeHost,Login,Senha,Email,Ativo")] HostProfile profile) {
            if(ModelState.IsValid) {
                //db.Cliente.Add(cliente);
                _reppositorio.Adicionar(profile);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(profile);
        }

        // GET: HostProfile/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            HostProfile profile = _reppositorio.Find(id);
            if(profile == null) {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: HostProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HostProfileID,TipoDeHost,Login,Senha,Email,Ativo")] HostProfile profile) {
            if(ModelState.IsValid) {

                _reppositorio.Atualizar(profile);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        // GET: HostProfile/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            HostProfile profile = _reppositorio.Find(id);
            if(profile == null) {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            HostProfile profile = _reppositorio.Find(id);

            //db.HostProfile.Remove(cliente);
            _reppositorio.Excluir(c => c == profile);

            //db.SaveChanges();
            _reppositorio.SalvarTodos();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            _reppositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
