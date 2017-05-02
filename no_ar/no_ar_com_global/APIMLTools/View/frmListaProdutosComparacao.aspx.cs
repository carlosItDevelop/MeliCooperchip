using System;
using System.Collections.Generic;
using Model;
using Models.Anuncio;
using Newtonsoft.Json;
using RestSharp;
using SDK;
using Result = Models.Anuncio.Result;

namespace View {
    public partial class FrmListaProdutosComparacao : System.Web.UI.Page {
        
        protected void Page_Load(object sender, EventArgs e) {
            
        }
        protected void btnEnviar_Click(object sender, EventArgs e) {
            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "category", Value = cboListaCategoria.Text };
            var p1 = new RestSharp.Parameter { Name = "offset", Value = Request["offset"] };
            List<Parameter> ps;
            if(!string.IsNullOrEmpty(Request["offset"])) {
                ps = new List<RestSharp.Parameter> { p, p1 };
            } else { ps = new List<RestSharp.Parameter> { p }; }

            IRestResponse response = m.Get("/sites/MLB/search?category=" + cboListaCategoria.Text + "&attribute=id,title,price,available_quantity,sold_quantity&sort=price_asc", ps);
            var anunc = JsonConvert.DeserializeObject<Anuncio>(response.Content);

            string linha = "";

            int qtde = anunc.paging.total;
            int numRegPorPg = anunc.paging.limit;
            int numPag = 0;

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }


            /* CABEÇALHO */
            linha += "<div class='CSS_Table_Example'>";
            linha += "<table>";

                    linha += "<tr><td>Limit</td><td>Registros</td><td>Página Atual</td><td>Categoria</td><td>Qtde Páginas</td></tr>";
                    linha += "<tr><td>" + anunc.paging.limit + "</td><td>" + anunc.paging.total + "</td><td>" + (anunc.paging.offset + 1) + "</td><td>" + cboListaCategoria.SelectedValue.ToUpper() + "</td><td>" + numPag + "</td></tr>";

            linha += "</table></div><hr />";
            /* FIM DO CABEÇALHO */


            /* DADOS */
            linha += "<div class='CSS_Table_Example'>";
            linha += "<table><tr><td>Anúncio ID</td><td>Título</td><td>Preço</td><td>Disponível</td><td>Vendidos</td></tr>";

            foreach(Result rs in anunc.results) {
                linha += "<tr><td><a href='frmAnuncioPorID.aspx?items=" + rs.id + "&code=" + code + "'>" + rs.id + "</a></td><td>" + rs.title + "</td><td>" + rs.price.ToString("0.00") + "</td><td>" + rs.available_quantity + "</td><td>" + rs.sold_quantity
            + "</td></tr>";
            }

            linha += "</table></div>";
            /* FIM DOS DADOS */


     //       linha += Paginacao.GetPaginacao(anunc.paging.total, anunc.paging.limit, numPag, vServer, code);

            lblResultJSON.Text = linha;


        }
    }
}