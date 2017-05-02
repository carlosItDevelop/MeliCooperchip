using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Repositorio.DAL.Contexto;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class FavoritosController : Controller
    {
        private BancoContexto db = new BancoContexto();

        // GET: Favoritos
        //public ActionResult Index()
        //{
        //    return View(db.TaskLists.ToList());
        //}
        public ActionResult Index(string tList, string SearchString) {

            var srcList = new List<string>();

            var srcQuery = from d in db.Favoritos
                                orderby d.Source
                                select d.Source;

            srcList.AddRange(srcQuery.Distinct());


            ViewBag.tList = new SelectList(srcList);

            var tagBusca = from fav in db.Favoritos
                          select fav;

            if(!string.IsNullOrEmpty(SearchString)) {
                tagBusca = tagBusca.Where(s => s.Tag.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(tList)) {
                tagBusca = tagBusca.Where(x => x.Source == tList);
            }

            return View(tagBusca);
        }


        // GET: Favoritos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favoritos favoritos = db.Favoritos.Find(id);
            if (favoritos == null)
            {
                return HttpNotFound();
            }
            return View(favoritos);
        }

        // GET: Favoritos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Favoritos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FavoritosId,Source,Tag,Link")] Favoritos favoritos)
        {
            if (ModelState.IsValid)
            {
                db.Favoritos.Add(favoritos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(favoritos);
        }

        // GET: Favoritos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favoritos favoritos = db.Favoritos.Find(id);
            if (favoritos == null)
            {
                return HttpNotFound();
            }
            return View(favoritos);
        }

        // POST: Favoritos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FavoritosId,Source,Tag,Link")] Favoritos favoritos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(favoritos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(favoritos);
        }

        // GET: Favoritos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favoritos favoritos = db.Favoritos.Find(id);
            if (favoritos == null)
            {
                return HttpNotFound();
            }
            return View(favoritos);
        }

        // POST: Favoritos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Favoritos favoritos = db.Favoritos.Find(id);
            db.Favoritos.Remove(favoritos);
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
