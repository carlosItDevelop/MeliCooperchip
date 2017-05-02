using System;

namespace View {
    public partial class FrmConfigMercadolivre : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack)
            {

                txtCodigoDoAPP.Text = Application["APPID"].ToString();
                txtSecretKey.Text = Application["SECRETKEY"].ToString();
                txtURLRetorno.Text = Application["URLRETORNO"].ToString();
                txtURLNotificacao.Text = Application["URLNOTIFICACAO"].ToString();
            }

        }
    }
}