using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using SDK;
using Infra.Entidades.ObjML;

namespace tools.App.Controllers
{
    [Authorize(Roles="Admin")]
    public class MlCategoriaController : Controller
    {
        // GET: MlCategoria
        public ActionResult Index()
        {

            var service = MeliService.GetService();
            var categorias = service.GetCatergories("MLB");
            return View(categorias);

        }

        public ActionResult SubCategoria() 
        {

            var service = MeliService.GetService();
            var categorias = service.GetCatergories("MLB");

            var _listaCat = new List<ListaDeSubCategoriaComQtde>();

            foreach(Categorias cat in categorias) 
            {
                _listaCat.Add(service.GetSubCategoria(cat.id));
            }

            return View(_listaCat);

        }


        public ActionResult DetalhesSubCategoria(string id) {

            var service = MeliService.GetService();
            var categoria = service.GetCatergories("MLB");
            var subcategorias = service.GetSubCategoria(id);

            /* ========================================= */            
            var _cat = from cat in categoria
                       orderby cat.id
                       select cat;

            var filterCat = _cat.Single(x => x.id == id).name;


            ViewBag.TituloSubcategoria = filterCat;

            var subCat = from sc in subcategorias.children_categories
                      orderby sc.id
                      select sc;


            // ------------------------------------------------------------------ //


            //public ActionResult Index(string certificacao, string searchString) {
            //    var certList = new List<string>();

            //    var certQuery = from d in db.Experts
            //                    orderby d.Certificacao
            //                    select d.Certificacao;

            //    certList.AddRange(certQuery.Distinct());
            //    ViewBag.certificacao = new SelectList(certList);

            //    var expert = from exp in db.Experts
            //                 select exp;

            //    if(!String.IsNullOrEmpty(searchString)) {
            //        expert = expert.Where(s => s.Nome.Contains(searchString));
            //    }

            //    if(!string.IsNullOrEmpty(certificacao)) {
            //        expert = expert.Where(x => x.Certificacao == certificacao);
            //    }

            //    return View(expert);
            //}


            return View(subCat);

        }

    }
}