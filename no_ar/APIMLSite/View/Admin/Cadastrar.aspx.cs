using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase {
    public partial class pages_signup : System.Web.UI.Page {
        public static string vServer = "";

        protected void Page_Load(object sender, EventArgs e) {
            vServer = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? "http://" + Request.ServerVariables["HTTP_HOST"] + ":27000" : "http://" + Request.ServerVariables["HTTP_HOST"]);

        }



        protected void btnCadastrar_Click(object sender, EventArgs e) {
            try {

                if ((chkAdmin.Checked == false) && (chkUser.Checked == false)) {
                    Util.Alertar("É necessário escolher o nível do usuário!");
                } else {
                    WebSecurity.CreateUserAndAccount(txtUsuario.Text, txtSenha.Text, new {
                        Nome = txtNome.Text,
                        Telefone = txtTelefone.Text,
                        DataNascimento = Convert.ToDateTime(txtDataNascimento.Text)
                    });
                    if(chkAdmin.Checked) Roles.AddUserToRole(txtUsuario.Text, "admin");
                    if(chkUser.Checked) Roles.AddUserToRole(txtUsuario.Text, "user");

                    Util.Alertar("Usuário cadastrado com sucesso.");
                    Response.Redirect(vServer + "/Admin/Listagem.aspx");
                }

            //} catch(InvalidOperationException ex) {
            } catch(Exception ex) {
                Util.Alertar(ex.Message);
            }
        }


    }
}