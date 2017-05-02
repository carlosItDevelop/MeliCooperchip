using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase.User
{
    public partial class Alterar : System.Web.UI.Page
    {
        public static string vServer = "";

        protected void Page_Load(object sender, EventArgs e) {
            vServer = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? "http://" + Request.ServerVariables["HTTP_HOST"] + ":27000" : "http://" + Request.ServerVariables["HTTP_HOST"]);

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            if (WebSecurity.ChangePassword(WebSecurity.CurrentUserName,
                txtSenhaAtual.Text, txtNovaSenha.Text))
            {                
                Util.Alertar("Senha alterada com sucesso.");
                Response.Redirect(vServer + "/User/Default.aspx");
            }
            else
            {                
                Util.Alertar("Não foi possível alterar sua senha.");
            }
        }
    }
}