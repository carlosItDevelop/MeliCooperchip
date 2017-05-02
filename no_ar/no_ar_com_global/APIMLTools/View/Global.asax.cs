using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace view {
    public class Global : HttpApplication {
        public static int VCount = 0;
        void Application_AcquireRequestState(object sender, EventArgs e) {
            if(VCount == 0) {
                var host = GetHost(HttpContext.Current);
                if(host.Substring(0, 9).Equals("localhost")) {
                    Application["APPID"] = ConfigurationManager.AppSettings["APPIDLOCAL"];
                    Application["SECRETKEY"] = ConfigurationManager.AppSettings["SECRETKEYLOCAL"];
                    Application["URLRETORNO"] = ConfigurationManager.AppSettings["URLRETORNOLOCAL"];
                    Application["URLNOTIFICACAO"] = ConfigurationManager.AppSettings["URLNOTIFICACAOLOCAL"];
                } else {
                    Application["APPID"] = ConfigurationManager.AppSettings["APPIDREMOTO"];
                    Application["SECRETKEY"] = ConfigurationManager.AppSettings["SECRETKEYREMOTO"];
                    Application["URLRETORNO"] = ConfigurationManager.AppSettings["URLRETORNOREMOTO"];
                    Application["URLNOTIFICACAO"] = ConfigurationManager.AppSettings["URLNOTIFICACAOREMOTO"];
                }
                Application["HOST"] = host;
            }
            if(VCount == 0) VCount++;
        }

        public static string GetHost(HttpContext context) {
            if(context == null) return null;
            var httpHost = context.Request.ServerVariables["HTTP_HOST"];
            if(string.IsNullOrEmpty(httpHost)) return null;
            return httpHost;
        }

        protected void Application_Start(object sender, EventArgs e) {
            Application["NICKNAME"] = ConfigurationManager.AppSettings["NICKNAME"];
            Application["APPNAME"] = ConfigurationManager.AppSettings["APPNAME"];
            Application["SELLER"] = ConfigurationManager.AppSettings["SELLER"];
        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}