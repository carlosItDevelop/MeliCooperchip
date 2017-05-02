using System;
using System.Collections.Generic;
using Model;
using Model.SobreAnunciosAlheios;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmAnunciosPorVendedor : System.Web.UI.Page {
        
        
        Meli _m;
        string _sellerId = "";

        protected void Page_Load(object sender, EventArgs e) {

        }

        
        protected void btnBuscaAnuncio_Click(object sender, EventArgs e) {

            // 1 - Instância da Auth
            this._m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            _sellerId = Util.GetIDUser(txtSeller.Text, _m);
            
            
            string linha = "";

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "access_token", Value = _m.AccessToken };

            var ps = new List<RestSharp.Parameter> { p };

            SobreAnunciosAlheios itemsAlheios;
            try {
                IRestResponse response = _m.Get("/users/" + _sellerId + "/items/search", ps);
                itemsAlheios = JsonConvert.DeserializeObject<SobreAnunciosAlheios>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }


            // https://api.mercadolibre.com/users/{sellerID}/items/search?access_token={...}


            int qtde = itemsAlheios.paging.total;
            int numRegPorPg = itemsAlheios.paging.limit;
            int numPag = 0;

            linha += "Limite: " + itemsAlheios.paging.limit + "<br />";
            linha += "Registros: " + itemsAlheios.paging.total + "<br />";
            linha += "Página Atual: " + (itemsAlheios.paging.offset + 1) + "<br /><hr />";

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }

            linha += "Qtde Páginas: " + numPag;

            linha += "<br /><hr />";
            linha += "User: " + txtSeller.Text;
            linha += "<br /><hr />";


            for(int k = 0; k < itemsAlheios.results.Count; k++) {
                linha += "<a href='frmAnuncioPorID.aspx?items=" + itemsAlheios.results[k] + "&code="+ code + ">" + itemsAlheios.results[k] + "</a>" + "<br />";
            }


            linha += "<hr />";

            foreach(AvailableFilter filtro in itemsAlheios.available_filters) {

                linha += filtro.name + "<br />";
                // linha += filtro.id + "<br />";

                for(int k = 0; k < filtro.values.Count; k++) {                    
                    linha += filtro.values[k].name + "<br />";
                    linha += filtro.values[k].results.ToString() + "<br /><hr />";
                }

            }


            linha += "<br /><hr />Meu AccessToken:    -    [" + _m.AccessToken + "]";
            linha += "<br /><hr />";
            lblResultJSON.Text += linha;
        }
    }
}