using System;
using System.Collections.Generic;
using Model;
using Models.TotalDeVisitas;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmConsultaVisitasPorUsuario : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnEnviar_Click(object sender, EventArgs e) {
            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());
            string code = Request["code"].ToString();

            // https://api.mercadolibre.com/users/59181149/items_visits?date_from=2014-11-01T00:00:00.000-00:00&date_to=2015-06-10T00:00:00.000-00:00 

            var p = new RestSharp.Parameter();
            p.Name = "date_from";
            p.Value = "2014-11-01T00:00:00.000-00:00";

            var p2 = new RestSharp.Parameter();
            p2.Name = "date_to";
            p2.Value = "2015-06-01T00:00:00.000-00:00";

            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);
            ps.Add(p2);

            IRestResponse response = m.Get("/users/"+ txtBuscaProduto.Text +"/items_visits", ps);
            var tVisitas = JsonConvert.DeserializeObject<TotalDeVisitasPorUser>(response.Content);


            string linha = "";

            linha += "<table id='tdVisita'><tr><td class='direita'>ID do Usuário: </td><td class='esquerda'>" + tVisitas.user_id.ToString() + "</td></tr>";
            linha += "<tr><td class='direita'>Data Inicial: </td><td class='esquerda'>" + Convert.ToDateTime(tVisitas.date_from).ToShortDateString() + "</td></tr>";
            linha += "<tr><td class='direita'>Data Final: </td><td class='esquerda'>" + Convert.ToDateTime(tVisitas.date_to).ToShortDateString() + "</td></tr>";
            linha += "<tr><td class='direita'>Total de Visitas: </td><td class='esquerda'>" + tVisitas.total_visits.ToString() + "</td></tr>";
            linha += "<tr style='background-color: grey;'><td></td><td></td></tr>";

            foreach(VisitsDetail visita in tVisitas.visits_detail) {
                linha += "<tr><td class='direita'>Compahia: </td><td class='esquerda'>" + visita.company + "</td></tr>";
                linha += "<tr><td class='direita'>Visitas: </td><td class='esquerda'>" + visita.quantity.ToString() + "</td></tr>";
            }
            linha += "<tr style='background-color: grey;'><td></td><td></td></tr></table>";

            lblResultJSON.Text = linha;

            // IMPORTANTE: PODE SER QUALQUER USUÁRIO, VISTO QUE NÃO PEDE ACCESS_TOKEN


        }

    }
}