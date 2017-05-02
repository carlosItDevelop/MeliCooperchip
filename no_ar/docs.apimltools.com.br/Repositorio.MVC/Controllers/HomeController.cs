using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Repositorio.MVC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Cooperchip | Note é a aplicação de documentação da Cooperchip e do projeto APIML | Tools.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Fique à vontade para falar conosco quando quiser ou precisar.";

            return View();
        }

    }
}