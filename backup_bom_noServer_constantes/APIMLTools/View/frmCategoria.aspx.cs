using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using SDK;
using Model;

namespace View {
    public partial class FrmCategoria : System.Web.UI.Page {
        

        protected void Page_Load(object sender, EventArgs e) {

            string linha = "";



            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            List<Categories> categoria;

            try {
                IRestResponse response = m.Get("/sites/MLB/categories");
                categoria = JsonConvert.DeserializeObject<List<Categories>>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            linha += "";

            int k = 0;



            /* DADOS */
            linha += "<div class='CSS_Table_Example'>";
            linha += "<table><tr><td>Controle</td><td>Id da Categoria</td><td>Nome da Categoria</td></tr>";



            foreach(Categories cat in categoria) {


                k++;
                linha += "<tr>";
                linha += "<td>" + k + "</td>";
                linha += "<td>" + cat.id + "</td>";
                linha += "<td>" + cat + "</td>"; // Não chamei a propriedade cat.Name, pois fiz um override no método ToString() retornando Name;
                linha += "</tr>";
            }

            linha += "</table></div>";
            /* FIM DOS DADOS */


            // linha += Paginacao.GetPaginacao(anunc.paging.total, anunc.paging.limit, numPag, "http://"+ Constants.Host, code);

            lblResultJSON.Text = linha;

        }
    }
}