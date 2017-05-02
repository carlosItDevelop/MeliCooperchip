using System;
using System.Collections.Generic;
using Model;
using Models.HotKeyWords;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmHotKeyWords : System.Web.UI.Page {
        
        
        
        protected void Page_Load(object sender, EventArgs e) {
            
            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"].ToString();

            IRestResponse response = m.Get("/sites/MLB/trends/search");

            var hotword = JsonConvert.DeserializeObject<List<HotKeyWords>>(response.Content);

            string linha = "";
       

            /* DADOS */
            linha += "<div class='CSS_Table_Example'>";
            linha += "<table>";
            linha += "<tr><td>Palavra Chave</td><td>Link dos Produtos Pesquisados</td></tr>";

            for(int k = 0; k < hotword.Count; k++) {
                linha += "<tr><td>"  + hotword[k].keyword +  "</td><td><a href='" + hotword[k].url + "' target='_blank'>" + hotword[k].url + "</a></td></tr>";
            }

            linha += "</table></div>";
            /* FIM DOS DADOS */


            lblResultJSON.Text = linha;


        }

    }
}