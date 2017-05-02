using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models.seller;

namespace View {
    public partial class FrmInfo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                lblResult.Text = "<h3>Constantes do Aplicativo - (Global.aspx & Web.config)</h3><br /";
                lblResult.Text += "<div class='col-md-6 col-lg-6'><table class='table'>";

                lblResult.Text += "<tr><th>Host</th><td>" + Application["HOST"] + "</td></tr>";
                lblResult.Text += "<tr><th>Apelido</th><td>" + Application["NICKNAME"] + "</td></tr>";
                lblResult.Text += "<tr><th>App Name</th><td>" + Application["APPNAME"] + "</td></tr>";
                lblResult.Text += "<tr><th>Seller ID</th><td>" + Application["SELLER"] + "</td></tr>";
                lblResult.Text += "<tr><th>App ID</th><td>" + Application["APPID"] + "</td></tr>";
                lblResult.Text += "<tr><th>Secret key</th><td>" + Application["SECRETKEY"] + "</td></tr>";
                                
                lblResult.Text += "</table></div>";

                lblResult.Text += "<br />Id do Vendedor: " + Application["SELLER"];
            }
        }
    }
}