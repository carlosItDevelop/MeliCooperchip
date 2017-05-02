using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", 
                "Usuario", "IdUsuario", "Email", true);
            if (!Roles.RoleExists("admin"))
            {
                Roles.CreateRole("admin");
            }
            if (!Roles.RoleExists("user"))
            {
                Roles.CreateRole("user");
            }
            if (!WebSecurity.UserExists("admin@softmark.com.br"))
            {
                WebSecurity.CreateUserAndAccount("admin@softmark.com.br", "admin", new
                {
                    Nome = "Administrador SimpleMembership",
                    Telefone = "(99) 9999-9999",
                    DataNascimento = Convert.ToDateTime("01/01/1980")
                });
                Roles.AddUserToRole("admin@softmark.com.br", "admin");
            }
            if (!WebSecurity.UserExists("user@softmark.com.br"))
            {
                WebSecurity.CreateUserAndAccount("user@softmark.com.br", "user", new
                {
                    Nome = "Usuário SimpleMembership",
                    Telefone = "(99) 9999-9999",
                    DataNascimento = Convert.ToDateTime("01/01/1980")
                });
                Roles.AddUserToRole("user@softmark.com.br", "user");
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}