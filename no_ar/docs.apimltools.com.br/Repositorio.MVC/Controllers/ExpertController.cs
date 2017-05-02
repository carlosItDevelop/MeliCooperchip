using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repositorio.DAL.Contexto;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    [Authorize(@Roles = "admin")]
    public class ExpertController : Controller
    {
        private BancoContexto db = new BancoContexto();

        //// GET: Expert/Detail?nome=str
        //public ActionResult Index()
        //{
        //    return View(db.Experts.ToList());
        //}

        public ActionResult Index(string certificacao, string searchString) {
            var certList = new List<string>();

            var certQuery = from d in db.Experts
                            orderby d.Certificacao
                            select d.Certificacao;

            certList.AddRange(certQuery.Distinct());
            ViewBag.certificacao = new SelectList(certList);

            var expert = from exp in db.Experts
                         select exp;

            if(!String.IsNullOrEmpty(searchString)) {
                expert = expert.Where(s => s.Nome.Contains(searchString));
            }

            if(!string.IsNullOrEmpty(certificacao)) {
                expert = expert.Where(x => x.Certificacao == certificacao);
            }

            return View(expert);
        }


        // GET: Expert/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        // GET: Expert/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expert/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExpertId,Nome,Datacadastro,Certificacao,HoraConsultoria,Email,WebSite,Twitter,Facebook,Linkedin")] Expert expert)
        {
            if (ModelState.IsValid)
            {
                db.Experts.Add(expert);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(expert);
        }

        // GET: Expert/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        // POST: Expert/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExpertId,Nome,Datacadastro,Certificacao,HoraConsultoria,Email,WebSite,Twitter,Facebook,Linkedin")] Expert expert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(expert);
        }

        // GET: Expert/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Expert expert = db.Experts.Find(id);
            if (expert == null)
            {
                return HttpNotFound();
            }
            return View(expert);
        }

        // POST: Expert/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Expert expert = db.Experts.Find(id);
            db.Experts.Remove(expert);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
