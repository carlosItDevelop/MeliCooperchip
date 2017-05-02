using SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tools.App.Controllers
{
    [Authorize(Roles="Admin")]
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao
        public ActionResult Index()
        {

            if(string.IsNullOrEmpty(Request["code"])) {
                var ms = MeliService.GetService();
                string redirectUrl = ms.Authorize();
                Response.Redirect(redirectUrl);
            }

            string _code = Request["code"];

            return RedirectToAction("Index", "Home", new { code=_code });

        }

        // GET: Autenticacao
        public ActionResult Logout()
        {

            Session.Abandon();
            Session.Clear();
            return RedirectToAction("Index", "Home");

        }

        


    }
}