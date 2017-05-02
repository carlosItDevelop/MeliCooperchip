using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleMembershipLocalDatabase.Admin
{
    public partial class Alterar : System.Web.UI.Page
    {
        public static string vServer = "";

        protected void Page_Load(object sender, EventArgs e) {
            vServer = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? "http://" + Request.ServerVariables["HTTP_HOST"] + ":27000" : "http://" + Request.ServerVariables["HTTP_HOST"]);



            if (!Page.IsPostBack)
            {
                int idUsuario; 
                if (int.TryParse(Request.QueryString["IdUsuario"], out idUsuario))
                {
                    using (var db = new SimpleMembershipEntities())
                    {
                        var usuario = db.Usuarios.SingleOrDefault(x => x.IdUsuario == idUsuario);
                        txtNome.Text = usuario.Nome;
                        txtTelefone.Text = usuario.Telefone;
                        txtDataNascimento.Text = usuario.DataNascimento.ToShortDateString();
                        txtUsuario.Text = usuario.Email;
                        chkAdmin.Checked = Roles.IsUserInRole(usuario.Email, "admin");
                        chkUser.Checked = Roles.IsUserInRole(usuario.Email, "user");
                    }
                }
                else
                {
                    Util.Alertar("Não foi possível localizar o usuário.");
                    Response.Redirect(vServer + "/Admin/Listagem.aspx");
                }
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            int idUsuario;
            if (int.TryParse(Request.QueryString["IdUsuario"], out idUsuario))
            {
                using (var db = new SimpleMembershipEntities())
                {
                    var usuario = db.Usuarios.SingleOrDefault(x => x.IdUsuario == idUsuario);
                    usuario.Nome = txtNome.Text;
                    usuario.Telefone = txtTelefone.Text;
                    usuario.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);                    
                   
                    if (chkAdmin.Checked)
                    {
                        if (!Roles.IsUserInRole(usuario.Email, "admin"))
                        {
                            Roles.AddUserToRole(usuario.Email, "admin");
                        }
                    }
                    else
                    {
                        if (Roles.IsUserInRole(usuario.Email, "admin"))
                        {
                            Roles.RemoveUserFromRole(usuario.Email, "admin");
                        }
                    }

                    if (chkUser.Checked)
                    {
                        if (!Roles.IsUserInRole(usuario.Email, "user"))
                        {
                            Roles.AddUserToRole(usuario.Email, "user");
                        }
                    }
                    else
                    {
                        if (Roles.IsUserInRole(usuario.Email, "user"))
                        {
                            Roles.RemoveUserFromRole(usuario.Email, "user");
                        }
                    }
                    db.SaveChanges();
                }
                Util.Alertar("Usuário alterado com sucesso.");
                Response.Redirect(vServer + "/Admin/Listagem.aspx");
            }
            else
            {
                Util.Alertar("Não foi possível localizar o usuário.");
                Response.Redirect(vServer + "/Admin/Listagem.aspx");
            }
        }
    }
}