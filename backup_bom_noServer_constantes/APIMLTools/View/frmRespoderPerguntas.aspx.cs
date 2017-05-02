using System;
using System.Collections.Generic;
using System.Configuration;
using Model;
using Model.CalculadorDeFreteViaAPI;
using Models.Perfil;
using Models.Pergunta;
using Newtonsoft.Json;
using RestSharp;
using SDK;

namespace View {
    public partial class FrmRespoderPerguntas : System.Web.UI.Page {

        string _vQuestionId;
        string _vPergunta;
        int _vFromid;
        string _vApelido;
        string _vItemId;
        Meli _m;
        Perfil _perfil;
        string _sellerId;
        Pergunta _pergunta;

        //private static CalculadorDeFreteViaAPI calcfrete;

        protected void Page_Load(object sender, EventArgs e) {

            _sellerId = ConfigurationManager.AppSettings["SELLER"].ToString();

            _vQuestionId = Request["id"];
            _vPergunta = Request["pergunta"];
            _vFromid = int.Parse(Request["fromid"]);
            _vApelido = Request["apelido"];
            _vItemId = Request["itemID"];

            if (!IsPostBack){

                try {

                    /* ========================================================================================================== */
                    // 1 - Instância da Auth
                    _m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());
                    _perfil = Util.GetPerfil(_m, _vFromid);
                    /* ========================================================================================================== */

                    lblPositivas.Text = ((_perfil.seller_reputation.transactions.ratings.positive) * 100).ToString();
                    lblNeutras.Text = ((_perfil.seller_reputation.transactions.ratings.neutral) * 100).ToString();
                    lblNegativas.Text = ((_perfil.seller_reputation.transactions.ratings.negative) * 100).ToString();

                    lblTotalTransacoes.Text = _perfil.seller_reputation.transactions.total.ToString();
                    lblTransacoesConcretizadas.Text = _perfil.seller_reputation.transactions.completed.ToString();
                    lblTransacoesCanceladas.Text = _perfil.seller_reputation.transactions.canceled.ToString();

                    lblPontosNoML.Text = _perfil.points.ToString();
                    lblDataDoCadastro.Text = Convert.ToDateTime(_perfil.registration_date).ToShortDateString();
                    lblStatusDoUsuario.Text = (_perfil.status.site_status == "active") ? "Ativo" : "Inativo";

                                        
                    /* ---------------------------------------------------------------------------------------------------------- */
           
                    /* ========================================================================================================== */
                    //pergunta = Util.GetPergunta(m, sellerID);
                    var p = new RestSharp.Parameter { Name = "seller_id", Value = ConfigurationManager.AppSettings["SELLER"] };
                    var p2 = new RestSharp.Parameter { Name = "access_token", Value = _m.AccessToken };
                    var ps = new List<RestSharp.Parameter> { p, p2 };

                    try {
                        IRestResponse response = _m.Get("/questions/search", ps);
                        _pergunta = JsonConvert.DeserializeObject<Pergunta>(response.Content);
                    } catch(Exception ex) {
                        lblResultJSON.Text = ex.Message;
                    }


                    /* ========================================================================================================== */

                    foreach(Question question in _pergunta.questions) {
                        if((question.from.id == _vFromid) && (question.from.answered_questions > 1) && (question.id.ToString() != _vQuestionId.ToString())) {
                            lblQtdePerguntas.Text = question.from.answered_questions.ToString();
                            lblPerguntas.Text += "<p style='backgroud-color: #e1e1e1;'>" + "<span>PERGUNTA: </span>" + Util.LimpaApostrofe(question.text) + "</p><hr />";
                            lblPerguntas.Text += "<p style='backgroud-color: #e100ff;'>" + "<span>RESPOSTA: </span>" + Util.LimpaApostrofe(question.answer.text) + "</p><hr />";
                        }
                    }

                    /* ---------------------------------------------------------------------------------------------------------- */
                    
                    
                    string linha = "";

                    linha += "<div>Pergunta ID: " + _vQuestionId + " - Por: " + _vFromid + " / " + _vApelido + "</div><hr />";
                    linha += Util.GetTitleItems(_vItemId, _m);
                    linha += "<hr />";


                    txtPergunta.Text = _vPergunta;

                    lblResultJSON.Text = linha;

                } catch(Exception ex) {
                    btnEnviar.Visible = false;
                    txtResposta.Visible = false; 
                    lblResultJSON.Text = "<h2>" + ex.Message + "</h2>";
                }                                
            }


            /* -------------------------------------------------------------------------------------- */
            //Meli m2 = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            //// https://api.mercadolibre.com/items/MLB598493587/shipping_options?zip_code=21765100 

            //var p22 = new RestSharp.Parameter();
            //p22.Name = "zip_code";
            //p22.Value = txtCep.Text;

            //var ps2 = new List<RestSharp.Parameter>();
            //ps2.Add(p22);

            //IRestResponse response2 = m2.Get("/items/" + _vItemID + "/shipping_options", ps2);
            //calcfrete = JsonConvert.DeserializeObject<CalculadorDeFreteViaAPI>(response2.Content);
            /* -------------------------------------------------------------------------------------- */

        }


        //public static CalculadorDeFreteViaAPI vCalcFrete = calcfrete;

        //[System.Web.Services.WebMethod]
        //public static string getDetalhesFrete() {

        //    string strInicial = "";

        //    strInicial += vCalcFrete.destination.extended_attributes.address + ", " + vCalcFrete.destination.extended_attributes.neighborhood + "\n" + vCalcFrete.destination.state.name + " / " + vCalcFrete.destination.city.name + " - " + vCalcFrete.destination.zip_code;

        //    string linha = "";
        //    foreach(Option opt in vCalcFrete.options) {
        //        if(linha != "") {
        //            linha += "\n---------------------------------\n";
        //        }
        //        linha += "Tipo de Frete: " + opt.name + " - Custo: R$ " + opt.cost;
        //        linha += "\nPrazo Estimado: " + Convert.ToDateTime(opt.estimated_delivery.date).ToShortDateString();
        //    }

        //    strInicial += "\n---------------------------------\n";
        //    strInicial += linha;

        //    return strInicial;

        //}


        protected void btnCalculaFrete_Click(object sender, EventArgs e) {

            Meli m = new Meli(Constants.AppId, Constants.SecretKey, Session["aToken"].ToString());

            /*
             * UTILIZANDO items
             */

            // https://api.mercadolibre.com/items/MLB598493587/shipping_options?zip_code=21765100 

            var p = new RestSharp.Parameter();
            p.Name = "zip_code";
            p.Value = txtCep.Text;


            var ps = new List<RestSharp.Parameter>();
            ps.Add(p);

            IRestResponse response = m.Get("/items/" + _vItemId + "/shipping_options", ps);
            var vCalcFrete = JsonConvert.DeserializeObject<CalculadorDeFreteViaAPI>(response.Content);



            string strInicial = "";

            strInicial += vCalcFrete.destination.extended_attributes.address + ", " + vCalcFrete.destination.extended_attributes.neighborhood + "\n" + vCalcFrete.destination.state.name + " / " + vCalcFrete.destination.city.name + " - " + vCalcFrete.destination.zip_code;

            string linha = "";
            foreach(Option opt in vCalcFrete.options) {
                if(linha != "") {
                    linha += "\n---------------------------------\n";
                }
                linha += "Tipo de Frete: " + opt.name + " - Custo: R$ " + opt.cost;
                linha += "\nPrazo Estimado: " + Convert.ToDateTime((string) opt.estimated_delivery.date).ToShortDateString();
            }

            strInicial += "\n---------------------------------\n";
            strInicial += linha;

            txtRotaFrete.Text = strInicial;

        }

        protected void btnEnviar_Click(object sender, EventArgs e) {

            /*
             * Antes de responder, analisar todos os campos e criticar.
             * Também observar se há bloqueios e realizá-los antes de tudo,
             * Observando se é necessário responder a pergunta ou apenas 
             * dar o post para bloqueios;
             */

            if(string.IsNullOrEmpty(txtResposta.Text) || string.IsNullOrEmpty(_vQuestionId)) {
                Response.Write("Campo ID e Resposta São Obrigatórios!");
                return;
            }

            var p = new RestSharp.Parameter { Name = "access_token", Value = _m.AccessToken };

            var ps = new List<RestSharp.Parameter> { p };

            try {
                IRestResponse r = _m.Post("/answers", ps, new { question_id = _vQuestionId, text = Util.LimpaApostrofe(txtResposta.Text) });
            } catch(Exception ex) { Response.Write(ex.Message); }

        }


    }
}