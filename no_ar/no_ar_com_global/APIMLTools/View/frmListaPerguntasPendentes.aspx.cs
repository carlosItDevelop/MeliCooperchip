using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.Pergunta;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmListaPerguntasPendentes : System.Web.UI.Page {

        

        protected void Page_Load(object sender, EventArgs e) {
            
            //--------------------------------------------------------------------------------------------------------------------------------------------

            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            string code = Request["code"];


            // COMENTEI O PARAMETRO P2 APENAS PARA TESTAR. EM PRODUÇÃO TEM DE FICAR ATIVO

            var p = new RestSharp.Parameter { Name = "seller_id", Value = ConfigurationManager.AppSettings["SELLER"] };
       //     var p2 = new RestSharp.Parameter { Name = "status", Value = "unanswered" };
            var p3 = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };

       //     var ps = new List<RestSharp.Parameter> { p, p2, p3 };
            var ps = new List<RestSharp.Parameter> { p, p3 };

            Pergunta question;

            try {
                IRestResponse response = m.Get("/questions/search", ps);
                question = JsonConvert.DeserializeObject<Pergunta>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            string linha = "";

            int vPagAtual = (string.IsNullOrEmpty(Request["offset"]) ? 0 : int.Parse(Request["offset"]));

            int numPag = 0;
            int qtde = question.total;
            int numRegPorPg = question.limit;


            if(qtde < 1) {
                lblResultJSON.Text = "<table align='center'  class='auto-style1'><tr><td>NÃO HÁ PERGUNTAS PENDENTES NO MOMENTO!</td></tr></table>";
                return;
            }


            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }

            linha += "<div class='CSS_Table_Example'>";
            linha += "<table>";
            linha += "<tr><td>Limit</td><td>Total Registro</td><td>Nº Página</td><td>Pág. Atual</td></tr>";
            linha += "<tr><td>" + numRegPorPg + "</td><td>" + qtde + "</td><td>" + numPag + "</td><td>" + (vPagAtual+1) + "</td></tr>";
            linha += "</table></div>";

            linha += "<hr />";


            linha += "<div class='CSS_Table_Example'><table><tr><td style='width: 15%;'>Ação</td><td style='width: 15%;'>Data</td><td style='width: 55%; White-Space:pre-wrap;'>Pergunta</td><td style='width: 15%;'>Apelido</td></tr>";

            string nick ="[]";
            foreach(Question r in question.questions) {
                nick = Util.GetNick(r.@from.id, m);
                linha += "<tr><td style='width: 15%;'><a href='frmRespoderPerguntas.aspx?id=" + r.id.ToString() + "&itemID=" + r.item_id + "&pergunta=" + Util.LimpaApostrofe(r.text) + "&code=" + code + "&fromid=" + r.@from.id.ToString() + "&apelido=" + nick + "'>" + "Responder" + "</a></td><td style='width: 15%;'>" + Convert.ToDateTime(r.date_created).ToShortDateString() + "</td><td style='width: 55%;  White-Space:pre-wrap;'>" + r.text + "</td><td style='width: 15%;'>" + nick + "</td></tr>";
            }

            linha += "</table></div>";


        //    linha += Paginacao.GetPaginacao(qtde, numRegPorPg, numPag, vServer, code);


            lblResultJSON.Text = linha;

            //    linha += "ID Anúncio: " + r.item_id + "<br />"; 
            //        linha += "Cliente: " + (r.@from != null ? "<a href='frmGetPerfilSellers.aspx?seller_id=" + r.@from.id + "'>" + r.@from.id + "</a>" : "[]") + "  -  Apelido: " + nick + "<br />";   

        }

    }
}