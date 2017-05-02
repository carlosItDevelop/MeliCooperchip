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
    public class ContatoController : Controller
    {
        //private BancoContexto db = new BancoContexto();
        private readonly ContatoRepositorio _reppositorio = new ContatoRepositorio();

        // GET: Contatos
        public ActionResult Index()
        {
            //return System.Web.UI.WebControls.View(db.Contatoes.ToList());
            return View(_reppositorio.GetAll().ToList());
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Contato contato = db.Contatoes.Find(id);
            Contato contato = _reppositorio.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind(Include = "ContatoID,Nome,Cpf,Endereco,Telefone,Celular,Email,Ativo")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //db.Contatoes.Add(contato);
                _reppositorio.Adicionar(contato);
                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(contato);
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Contato contato = db.Contatoes.Find(id);
            Contato contato = _reppositorio.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(
            [Bind(Include = "ContatoID,Nome,Cpf,Endereco,Telefone,Celular,Email,Ativo")] Contato contato)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(contato).State = EntityState.Modified;
                _reppositorio.Atualizar(contato);
                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Contato contato = db.Contatoes.Find(id);
            Contato contato = _reppositorio.Find(id);
            if (contato == null)
            {
                return HttpNotFound();
            }
            return View(contato);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Contato contato = db.Contatoes.Find(id);
            Contato contato = _reppositorio.Find(id);
            //db.Contatoes.Remove(contato);
            _reppositorio.Excluir(c => c == contato);
            //db.SaveChanges();
            _reppositorio.SalvarTodos();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            _reppositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
