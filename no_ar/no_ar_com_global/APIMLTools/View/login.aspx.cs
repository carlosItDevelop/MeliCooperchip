using System;

namespace View
{
    public partial class Login : System.Web.UI.Page
    {

        

        protected void Page_Load(object sender, EventArgs e) {

            

        }

        protected void btnLogin_Click(object sender, EventArgs e) {
            if(txtEmail.Text == "carlos.poetarj@gmail.com" && txtSenha.Text == "abaj1me1") {
               // Response.Redirect("http://"+Application["HOST"] + "/recursos.aspx");
                Response.Redirect("http://"+Application["HOST"] + "/default.aspx");
            } else {
               lblError.Text = "Usuário ou Senha não confere";
            }
        }
    }
}