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
    public class TaskListController : Controller
    {
        private BancoContexto db = new BancoContexto();

        // GET: TaskList
        //public ActionResult Index()
        //{
        //    return View(db.TaskLists.ToList());
        //}
        public ActionResult Index(string pList, string SearchString) {
            
            var priorityList = new List<string>();

            var priorityQuery = from d in db.TaskLists
                                orderby d.Prioridade
                                select d.Prioridade;

            priorityList.AddRange(priorityQuery.Distinct());


            ViewBag.pList = new SelectList(priorityList);

            var taslist = from task in db.TaskLists
                                       select task;

            if(!string.IsNullOrEmpty(SearchString)) {
                taslist = taslist.Where(s => s.Descricao.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(pList)) {
                taslist = taslist.Where(x => x.Prioridade == pList);
            }

            return View(taslist);
        }


        // GET: TaskList/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskList taskList = db.TaskLists.Find(id);
            if (taskList == null)
            {
                return HttpNotFound();
            }
            return View(taskList);
        }

        // GET: TaskList/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaskList/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskListId,DataCriacao,Prioridade,Descricao,Concruida")] TaskList taskList)
        {
            if (ModelState.IsValid)
            {
                db.TaskLists.Add(taskList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskList);
        }

        // GET: TaskList/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskList taskList = db.TaskLists.Find(id);
            if (taskList == null)
            {
                return HttpNotFound();
            }
            return View(taskList);
        }

        // POST: TaskList/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskListId,DataCriacao,Prioridade,Descricao,Concruida")] TaskList taskList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskList);
        }

        // GET: TaskList/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskList taskList = db.TaskLists.Find(id);
            if (taskList == null)
            {
                return HttpNotFound();
            }
            return View(taskList);
        }

        // POST: TaskList/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TaskList taskList = db.TaskLists.Find(id);
            db.TaskLists.Remove(taskList);
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
