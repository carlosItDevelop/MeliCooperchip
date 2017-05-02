using System.Linq;
using System.Net;
using System.Web.Mvc;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.MVC.Controllers
{
    [Authorize(Roles = "admin")]
    public class AgendaController : Controller
    {
        // Troca o contexto
        //private BancoContexto db = new BancoContexto();
        private readonly AgendaRepositorio _reppositorio = new AgendaRepositorio();

        // GET: Agenda
        public ActionResult Index() {
            //return View(db.Cliente.ToList());
            return View(_reppositorio.GetAll().ToList());
        }

        // GET: Agenda/Details/5
        public ActionResult Details(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Cliente.Find(id);
            Agenda agenda = _reppositorio.Find(id);

            if(agenda == null) {
                return HttpNotFound();
            }
            return View(agenda);
        }



        // GET: Agenda/Create
        public ActionResult Create() {
            return View();
        }

        // POST: Agenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgendaID,Evento,Agente,Descricao,Data,Prioridade,Status")] Agenda agenda) {
            if(ModelState.IsValid) {
                //db.Cliente.Add(cliente);
                _reppositorio.Adicionar(agenda);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }

            return View(agenda);
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Cliente.Find(id);
            Agenda agenda = _reppositorio.Find(id);
            if(agenda == null) {
                return HttpNotFound();
            }
            return View(agenda);
        }

        // POST: Agenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AgendaID,Evento,Agente,Descricao,Data,Prioridade,Status")] Agenda agenda) {
            if(ModelState.IsValid) {
                //db.Entry(cliente).State = EntityState.Modified;
                _reppositorio.Atualizar(agenda);

                //db.SaveChanges();
                _reppositorio.SalvarTodos();
                return RedirectToAction("Index");
            }
            return View(agenda);
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(int? id) {
            if(id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Cliente cliente = db.Cliente.Find(id);
            Agenda agenda = _reppositorio.Find(id);
            if(agenda == null) {
                return HttpNotFound();
            }
            return View(agenda);
        }

        // POST: Agenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            //Cliente cliente = db.Cliente.Find(id);
            Agenda agenda = _reppositorio.Find(id);

            //db.Cliente.Remove(cliente);
            _reppositorio.Excluir(c => c == agenda);

            //db.SaveChanges();
            _reppositorio.SalvarTodos();
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing) {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            _reppositorio.Dispose();
            base.Dispose(disposing);
        }
    }
}
