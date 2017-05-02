using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDK;

namespace tools.App.Controllers
{
    public class TipoPublicidadeController : Controller
    {
        // GET: TipoPublicidade
        public ActionResult Index()
        {

            var tipospublicidades = MeliService.GetService().GetTipoPublicidade();
            var listaTP = from tp in tipospublicidades
                          select tp;

            return View(listaTP);
        }
    }
}