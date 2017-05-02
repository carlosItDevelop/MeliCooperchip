using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase.Admin
{
    public partial class Listagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable gvUsuarios_GetData()
        {
            //var usuarios = new List<object>();
            //usuarios.Add(new
            //{
            //    Nome = "Usuário 1",
            //    Email = "user1@gmail.com",
            //    Telefone = "(99) 9999-9999",
            //    DataNascimento = Convert.ToDateTime("01/01/1980")
            //});
            //usuarios.Add(new
            //{
            //    Nome = "Usuário 2",
            //    Email = "user2@gmail.com",
            //    Telefone = "(99) 9999-9999",
            //    DataNascimento = Convert.ToDateTime("01/01/1980")
            //});
            //usuarios.Add(new
            //{
            //    Nome = "Usuário 3",
            //    Email = "user3@gmail.com",
            //    Telefone = "(99) 9999-9999",
            //    DataNascimento = Convert.ToDateTime("01/01/1980")
            //});
            //return usuarios;

            var db = new SimpleMembershipEntities();
            return db.Usuarios.AsQueryable();            
        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "excluir")
            {
                string usuario = e.CommandArgument.ToString();
                try
                {
                    if (Roles.GetRolesForUser(usuario).Count() > 0)
                    {
                        Roles.RemoveUserFromRoles(usuario, Roles.GetRolesForUser(usuario));
                    }
                    ((SimpleMembershipProvider)Membership.Provider).DeleteAccount(usuario);
                    ((SimpleMembershipProvider)Membership.Provider).DeleteUser(usuario, true);
                    Util.Alertar("Usuário excluído com sucesso.");
                    gvUsuarios.DataBind();
                }
                catch (Exception ex)
                {
                    Util.Alertar(string.Format(
                        "Erro ao tentar excluir o usuário.<br/><br/>{0}", ex.Message));
                }
            }
        }
    }
}