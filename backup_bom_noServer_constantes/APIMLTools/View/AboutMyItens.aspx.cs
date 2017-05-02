using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.SobreMeusAnuncios;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class AboutMyItens : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {


            string linha = "";



            // 1 - Instância da Auth
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };

            var ps = new List<RestSharp.Parameter> { p };

            SobreMeusAnuncios myItens;
            try {
                IRestResponse response = m.Get("/users/" + ConfigurationManager.AppSettings["SELLER"] + "/items/search", ps);

                //Object jObject = JsonConvert.DeserializeObject<Object>(response.Content);
                //DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jObject.ToString());
                                
                myItens = JsonConvert.DeserializeObject<SobreMeusAnuncios>(response.Content);

            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            int qtde = myItens.paging.total;
            int numRegPorPg = myItens.paging.limit;
            int numPag = 0;

            linha += "Limite: " + myItens.paging.limit + "<br />";
            linha += "Registros: " + myItens.paging.total + "<br />";
            linha += "Página Atual: " + (myItens.paging.offset + 1) + "<br /><hr />";

            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }

            linha += "Qtde Páginas: " + numPag;

            linha += "<br /><hr />";


            for(int k = 0; k < myItens.results.Count; k++) {
                linha += "<a href='frmAnuncioPorID.aspx?items=" + myItens.results[k] + "&code="+ code + "'>" + myItens.results[k] + "</a>" + "<br />";
            }


            linha += "<hr />";

            foreach(AvailableFilter filtro in myItens.available_filters) {

                linha += filtro.name + "<br />";
                // linha += filtro.id + "<br />";

                for(int k = 0; k < filtro.values.Count; k++) {
                    linha += filtro.values[k].name + "<br />";
                    linha += filtro.values[k].results + "<br /><hr />";
                }

            }


            linha += "<br /><hr />Meu AccessToken:    -    [" + m.AccessToken + "]";
            linha += "<br /><hr />";
            lblResultJSON.Text += linha;

        }

    }
}