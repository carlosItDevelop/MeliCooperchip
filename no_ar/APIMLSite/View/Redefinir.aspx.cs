using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase {

    public partial class Redefinir : System.Web.UI.Page {

        public static string vServer = "";

        protected void Page_Load(object sender, EventArgs e) {

            vServer = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? "http://" + Request.ServerVariables["HTTP_HOST"] + ":27000" : "http://" + Request.ServerVariables["HTTP_HOST"]);
            
            
            var usuario = Request.QueryString["usuario"];
            var token = Request.QueryString["token"];
            if(!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(token)) {
                if(WebSecurity.UserExists(usuario)) {
                    var novaSenha = Util.GerarSenhaAleatoria(6);
                    var redefiniu = WebSecurity.ResetPassword(token, novaSenha);
                    if(redefiniu) {
                        var linkLogin = string.Format(
                            "<a href='" + vServer + "/Login.aspx?usuario={0}'>clique aqui</a>", usuario);
                        var mensagem = new StringBuilder();
                        mensagem.Append("<h3>Nova Senha</h3>");
                        mensagem.Append("<p>Você solicitou uma nova senha de acesso ao nosso site.</p>");
                        mensagem.Append("<p>A sua nova senha é:</p>");
                        mensagem.AppendFormat("<p><b>{0}</b></p>", novaSenha);
                        mensagem.AppendFormat("<p>Para fazer o login agora mesmo, {0}.</p>", linkLogin);
                        mensagem.Append("<p>Atenciosamente,<br/>");
                        mensagem.Append("Equipe APIML | Tools</p>");
                        Util.EnviarEmail("Nova Senha", mensagem.ToString(), usuario);
                        Util.Alertar("Foi enviada uma mensagem para seu e-mail com uma nova senha de acesso ao nosso site.");
                        Response.Redirect("href='" + vServer + "/Login.aspx");
                    } else {
                        Util.Alertar("Não foi possível gerar uma nova senha de acesso.");
                        Response.Redirect("href='" + vServer + "/Esqueceu.aspx'");
                    }
                } else {
                    Util.Alertar(string.Format(
                        "O usuário <b>{0}</b> não foi encontrado em nossa base de dados.", usuario));
                    Response.Redirect("href='" + vServer + "/Esqueceu.aspx'");
                }
            } else {
                Util.Alertar("Nome de usuário e/ou token de validação inválido(s).");
                Response.Redirect("href='" + vServer + "/Esqueceu.aspx'");
            }
        }
    }
}