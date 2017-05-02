using System;
using System.Web.UI;
using WebMatrix.WebData;

namespace SimpleMembershipLocalDatabase {
    public partial class frontend : MasterPage {

        public static string vServer = "";

        protected void Page_Load(object sender, EventArgs e) {
            vServer = (Request.ServerVariables["HTTP_HOST"].Equals("localhost") ? "http://" + Request.ServerVariables["HTTP_HOST"] + ":27000" : "http://" + Request.ServerVariables["HTTP_HOST"]);


        }


        protected void btnLogout_Click(object sender, EventArgs e) {
            WebSecurity.Logout();
            Response.Redirect(vServer + "/Login.aspx");
        }

    }
}