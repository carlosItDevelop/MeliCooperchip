using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase {
    public partial class Esqueceu : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnSolicitar_Click(object sender, EventArgs e) {
            if(WebSecurity.UserExists(txtUsuario.Text)) {
                var token = WebSecurity.GeneratePasswordResetToken(txtUsuario.Text);
                var linkRedefinir = string.Format(
                    "<a href='http://localhost:13180/Redefinir.aspx?usuario={0}&token={1}'>clique aqui</a>",
                    txtUsuario.Text, token);
                var mensagem = new StringBuilder();
                mensagem.Append("<h3>Redefinição de Senha</h3>");
                mensagem.Append("<p>Recebemos uma soliticação de redefinição ");
                mensagem.Append("da senha de acesso ao nosso portal.</p>");
                mensagem.Append("<p>Se foi realmente você que fez a solicitação, ");
                mensagem.AppendFormat("{0} para redefinir sua senha agora mesmo.</p>", linkRedefinir);
                mensagem.Append("<p>Caso não tenha feito essa solicitação, ignore esta mensagem.</p>");
                mensagem.Append("<p>Atenciosamente,<br/>");
                mensagem.Append("Equipe Softmark</p>");
                Util.EnviarEmail("Redefinição de Senha", mensagem.ToString(), txtUsuario.Text);
                Util.Alertar("Foi enviada uma mensagem para seu e-mail informando como proceder para redefinir sua senha.");
            } else {
                Util.Alertar(string.Format("O usuário <b>{0}</b> não foi encontrado em nossa base de dados.",
                    txtUsuario.Text));
            }
        }

    }
}