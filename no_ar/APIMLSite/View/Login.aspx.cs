using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase {
    public partial class pages_signin : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!Page.IsPostBack) {
                var returnUrl = Request.QueryString["ReturnUrl"];
                if(!string.IsNullOrEmpty(returnUrl) && WebSecurity.IsAuthenticated) {
                    Util.Alertar("Você não tem permissão para acessar a página solicitada. Faça o login com credenciais válidas para acessar a página solicitada.");
                }

                var usuario = Request.QueryString["usuario"];
                if(!string.IsNullOrEmpty(usuario)) {
                    txtUsuario.Text = usuario;
                    txtSenha.Focus();
                }
            }
        }

        protected void btnEntrar_Click(object sender, EventArgs e) {

            try
            {
                if (WebSecurity.Login(txtUsuario.Text, txtSenha.Text))
                {
                    var returnUrl = Request.QueryString["ReturnUrl"];
                    if (string.IsNullOrEmpty(returnUrl))
                    {
                        Response.Redirect("User/Default.aspx");
                    }
                    else
                    {
                        Response.Redirect(returnUrl);
                    }
                }
                else
                {
                    Util.Alertar("Credenciais de login inválidas.");
                }

            } catch(ArgumentException isErroParamr) {
                Util.Alertar("Parâmetro não pode ser Nulo - Nome do paramêtro: " + isErroParamr.ParamName);
            } catch(NullReferenceException isNullError) {
                Util.Alertar("Referência Nula não permitida!");
            } catch(Exception ex) {
                Util.Alertar(ex.Message);
            }
        }
    }
}