using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Models.Pergunta;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmPerguntasAllQuestions : System.Web.UI.Page {


        
        protected void Page_Load(object sender, EventArgs e) {
            



            // 1 - Instância da Auth
            Meli m = new Meli(Convert.ToInt64(Application["APPID"]), Application["SECRETKEY"].ToString(), Session["aToken"].ToString());

            string code = Request["code"];

            var p = new RestSharp.Parameter { Name = "seller_id", Value = ConfigurationManager.AppSettings["SELLER"] };
            var p2 = new RestSharp.Parameter { Name = "access_token", Value = m.AccessToken };
            var p3 = new RestSharp.Parameter { Name = "limit", Value = 10 };

            var ps = new List<RestSharp.Parameter> { p, p2, p3 };

            Pergunta question;
            try {
                IRestResponse response = m.Get("/questions/search", ps);
                question = JsonConvert.DeserializeObject<Pergunta>(response.Content);
            } catch(Exception ex) {
                lblResultJSON.Text = ex.Message;
                return;
            }

            string linha = "";

            // Recebe página atual;
            int vOffset;
            if(string.IsNullOrEmpty(Request["offset"])) {
                vOffset = 0;
            } else {
                vOffset = int.Parse(Request["offset"]);
            }            


            int qtde = question.total;
            int numRegPorPg = question.limit;
            int numPag = 0;


            if(qtde % numRegPorPg == 0) {
                numPag = qtde / numRegPorPg;
            } else {
                numPag = (qtde / numRegPorPg) + 1;
            }


            /* --------------------------------------------------- */
            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //

            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";
            /* --------------------------------------------------- */
            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>Limite</th>";
            linha += "<th>Registros</th>";
            linha += "<th>Página Atual</th>";
            linha += "<th>Qtde Páginas</th>";
            linha += "<th>ID Vendedor</th>";
            linha += "<th>Apelido Vendedor</th>";
            linha += "</tr>";
            linha += "</thead>";
            /* --------------------------------------------------- */
            linha += "<tbody>";
            linha += "<tr>";
            linha += "<td>" + numRegPorPg + "</td>";
            linha += "<td>" + qtde + "</td>";
            linha += "<td>" + (vOffset+1) + "</td>";
            linha += "<td>" + numPag + "</td>";
            linha += "<td>" + ConfigurationManager.AppSettings["SELLER"] + "</td>";
            linha += "<td>" + Util.GetNick(int.Parse(ConfigurationManager.AppSettings["SELLER"].ToString()), m ) + "</td>";
            linha += "</tr>";
            /* --------------------------------------------------- */
            linha += "</tbody>";
            linha += "</table>";

            // CABEÇALHO DA TABELA COM OS DADOS DO CROSDOCKING //
            /* --------------------------------------------------- */



        linha += "<div class='panel-body'>";

        linha += Util.GetPaginacao("", qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, "frmPerguntasAllQuestions.aspx");

            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<tbody>";
            /* --------------------------------------------------- */

            /* --------------------------------------------------- */
            foreach(Question r in question.questions) {

                        linha += "<thead>";
                        linha += "<tr>";
                        linha += "<th style='text-align: center;'>ID Pergunta</th>";
                        linha += "<th style='text-align: center;'>ID Anúncio</th>";
                        linha += "<th style='text-align: center;'>Qtde Respondidas</th>";
                        linha += "<th style='text-align: center;'>ID Cliente</th>";
                        linha += "<th style='text-align: center;'>Apelido Cliente</th>";
                        linha += "<th style='text-align: center;'>Ativa ?</th>";
                        linha += "<th style='text-align: center;'>Respondida ?</th>";
                        linha += "</tr>";
                        linha += "</thead>";


                        linha += "<tr>";
                            linha += "<td style='text-align: center;'>" + r.id + "</td>";
                            linha += "<td style='text-align: center;'>" + r.item_id + "</td>";
                            linha += "<td style='text-align: center;'>" + (r.from != null ? r.from.answered_questions.ToString() : "[]") + "</td>";

                            linha += "<td style='text-align: center;'>" + (r.from != null ? "<a href='frmGetPerfilSellers.aspx?seller_id=" + r.from.id + "'>" + r.from.id + "</a>" : "[]") + "</td>";
                            linha += "<td style='text-align: center;'>" + Util.GetNick(r.from.id, m) + "</td>";
                            linha += "<td style='text-align: center;'>" + (r.answer != null ? (r.answer.status.Equals("ACTIVE") ? "[SIM]" : "[NÃO]") : "[]") + "</td>";
                            linha += "<td style='text-align: center;'>" + (r.status.Equals("ANSWERED") ? "[SIM]" : "[NÃO]") + "</td>";
                        linha += "</tr>";
                        linha += "<tr>";
                            linha += "<td colspan='7'>&nbsp;</td>";
                        linha += "</tr>";
                        linha += "<tr>";
      //      linha += "<thead>";

                            linha += "<td colspan='4' style='text-align: center'><strong>PERGUNTA EM:  " + Convert.ToDateTime(r.date_created).ToShortDateString() + "</strong></td>";
                            linha += "<td colspan='3' style='text-align: center'><strong>RESPOSTA EM:  " + (r.answer != null ? Convert.ToDateTime(r.answer.date_created).ToShortDateString() : "[]") + "</strong></td>";
      //      linha += "</thead>";
                        linha += "</tr>";
                        linha += "<tr>";
                            linha += "<td colspan='7'>&nbsp;</td>";
                        linha += "</tr>";
                        linha += "<tr>";
                            linha += "<td colspan='4'>" + r.text + "</td>";
                            linha += "<td colspan='3'>" + (r.answer != null ? r.answer.text : "[]") + "</td>";
                        linha += "</tr>";


            }
            /* --------------------------------------------------- */
            linha += "</tbody>";
            linha += "</table>";

            linha += Util.GetPaginacao("", qtde, numRegPorPg, numPag, "http://"+Application["HOST"], code, vOffset, "frmPerguntasAllQuestions.aspx");

       linha += "</div>";


            // return linha;            

            lblResultJSON.Text = linha;


        }

    }
}