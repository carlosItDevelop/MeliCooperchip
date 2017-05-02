using System;
using System.Data;

namespace View {
    public partial class FrmLerXml : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if(!IsPostBack) {

                //string linha = "";
                //string sCaminhoDoArquivo = Server.MapPath("~/downloads/Hayamax.XML");
                //lblResult.Text = ReadXMLDataSet(sCaminhoDoArquivo, linha);

            }
        }



        public string ReadXmlDataSetHayamax(string pathXml, string linha) {
            DataSet ds = new DataSet();
            ds.ReadXml(pathXml);

            /* 
            * DataSet que guarda as Informações/Attibutes 
            * da Tabela (DataTable) CrossDoking, extraída do XML.
            */
            DataTable dtct = new DataTable();
            dtct = ds.Tables["crossDocking"];

            linha += "<div class='col-lg-12'>";
            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";
                linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";

                        linha += "<thead>";
                        linha += "<tr>";
                            linha += "<th>CUSTOMER ID</th>";
                            linha += "<th>COMPANY</th>";
                            linha += "<th>DATABASE</th>";
                            linha += "<th>Nº REGISTROS</th>";
                        linha += "</tr>";
                        linha += "</thead>";

                        linha += "<tr>";
                        linha += "<td>" + dtct.Rows[0]["customerId"].ToString() + "</td>";
                        linha += "<td>" + dtct.Rows[0]["company"].ToString() + "</td>";
                        linha += "<td>" + dtct.Rows[0]["database"].ToString() + "</td>";
                        linha += "<td>" + dtct.Rows[0]["numberResults"].ToString() + "</td>";
                        linha += "</tr>";

                linha += "</table>";
            linha += "</div>";
            linha += "</div>";





            /* 
            * DataSet que guarda as Informações/Attibutes 
            * da Tabela (DataTable) Product, extraída do XML.
            */
            DataTable dtprod = new DataTable();
            dtprod = ds.Tables["product"];


            /* 
            * DataSet que guarda as Informações/Attibutes 
            * da Tabela (DataTable) information, extraída do XML. 
            */
            DataTable dtinfo = new DataTable();
            dtinfo = ds.Tables["information"];

            int k = 0;


            linha += "<div class='row'>";
            linha += "<div class='col-lg-12'>";
                linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";

                    linha += "<div class='panel-heading'>";
                        linha += "<h4 class='panel-title'>CrossDocking Hayamax</h4>";
                    linha += "</div>";

                    linha += "<div class='panel-body'>";

                        linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
                            linha += "<thead>";
                                linha += "<tr>";
                                    linha += "<th>PRODUTO ID</th>";
                                    linha += "<th>MARCA</th>";
                                    linha += "<th>DENOMINAÇÃO</th>";
                                    linha += "<th>SEGMENTAÇÃO</th>";
                                    linha += "<th>QTDE-DISPONÍVEL</th>";
                                    linha += "<th>GARANTIA (MÊS)</th>";
                                    linha += "<th>PREÇO/CLIENTE</th>";
                                linha += "</tr>";
                            linha += "</thead>";


                            linha += "<tfoot>";
                                linha += "<tr>";
                                    linha += "<th>PRODUTO ID</th>";
                                    linha += "<th>MARCA</th>";
                                    linha += "<th>DENOMINAÇÃO</th>";
                                    linha += "<th>SEGMENTAÇÃO</th>";
                                    linha += "<th>QTDE-DISPONÍVEL</th>";
                                    linha += "<th>GARANTIA (MÊS)</th>";
                                    linha += "<th>PREÇO/CLIENTE</th>";
                                linha += "</tr>";
                            linha += "</tfoot>";
                        linha += "<tbody>";



            foreach(DataRow drprod in dtprod.Rows) {



                //linha += "LINK-IMAGE:  " + "<a href='" + drprod["image"].ToString() + "' target='_blank'>" + drprod["image"].ToString() + "</a>" + "<hr />";
                //linha += "LINK-PRODUTO:  " + "<a href='" + drprod["link"].ToString() + "' target='_blank'>" + drprod["link"].ToString() + "</a>" + "<hr />";
                //linha += "CLASSIF.FISCAL:  " + drprod["NBM"].ToString() + "<hr />";
                //linha += "UND DE VENDA:  " + drprod["saleUnit"].ToString() + "<hr />";

                //linha += "QTDE-UND-VENDA:  " + drprod["saleQuant"].ToString() + "<hr />";
                //linha += "PESO:  " + drprod["weightValue"].ToString() + "<hr />";
                //linha += "UND-PESO:  " + drprod["weightUnit"].ToString() + "<hr />";
                //linha += "NOME CURTO:  " + drprod["shortName"].ToString() + "<hr />";

                //linha += "COD-BARRA:  " + drprod["EAN"].ToString() + "<hr />";
                //linha += "COMPRIMENTO-MM:  " + drprod["width"].ToString() + "<hr />";
                //linha += "ALTURA-MM:  " + drprod["height"].ToString() + "<hr />";
                //linha += "PROFUNDIDADE-MM:  " + drprod["depth"].ToString() + "<hr />";

                //// Imorimir information //
                //linha += "DESCRIÇÃO:  " + dtinfo.Rows[k]["description"].ToString() + "<hr />";
                //linha += "CARACTERÍSTICAS:  " + dtinfo.Rows[k]["characteristics"].ToString() + "<hr />";
                //linha += "CARAC-TÉCNICAS:  " + dtinfo.Rows[k]["technical"].ToString() + "<hr />";
                //linha += "ITENS INCLUSOS:  " + dtinfo.Rows[k]["included"].ToString() + "<hr />";
                ////---------------------//


                //linha += "PADRÃO [1=INCENTIVO]:  " + drprod["PPB"].ToString() + "<hr />";
                //linha += "QTDE-DISPONÍVEL:  " + drprod["stock"].ToString() + "<hr />";

                //linha += "IPI/VENDA:  " + drprod["IPI"].ToString() + "<hr />";
                //linha += "UF/FATURAMENTO:  " + drprod["sourceFat"].ToString() + "<hr />";
                //linha += "<br /><hr /><hr /><hr /><hr /><hr /><br />";


                            linha += "<tr>";
                                linha += "<td>" + drprod["prod_id"].ToString() + "</td>";
                                linha += "<td>" + drprod["brand"].ToString() + "</td>";
                                linha += "<td>" + drprod["prod_name"].ToString() + "</td>";
                                linha += "<td>" + drprod["seg_name"].ToString() + "</td>";
                                linha += "<td>" + drprod["stock"].ToString() + "</td>";
                                linha += "<td>" + drprod["warrantyDays"].ToString() + "</td>";
                                linha += "<td>R$ " + drprod["price"].ToString() + "</td>";
                            linha += "</tr>";

                k++;
            }




                        linha += "</tbody>";

                    linha += "</table>";
                linha += "</div>";
            linha += "</div>";

        linha += "</div>";
        linha += "</div>";




            dtprod.Dispose();
            dtinfo.Dispose();
            dtct.Dispose();

            return linha;

        }



        public string ReadXmlDataSetAldo(string pathXml, string linha) {
            
            DataSet ds = new DataSet();
            ds.ReadXml(pathXml);

            /* 
            * DataSet que guarda as Informações/Attibutes 
            * da Tabela (DataTable) CrossDoking, extraída do XML.
            */
            DataTable dtAldo = new DataTable();
            dtAldo = ds.Tables[0];



            linha += "<div class='col-lg-12'>";
            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";
            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";

            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>CUSTOMER ID</th>";
            linha += "<th>COMPANY</th>";
            linha += "<th>DATABASE</th>";
            linha += "<th>Nº REGISTROS</th>";
            linha += "</tr>";
            linha += "</thead>";

            linha += "<tr>";
            linha += "<td>" + "Cooperchip" + "</td>";
            linha += "<td>" + "Aldo" + "</td>";
            linha += "<td>" + "20/04/2015" + "</td>";
            linha += "<td>" + dtAldo.Rows.Count + "</td>";
            linha += "</tr>";

            linha += "</table>";
            linha += "</div>";
            linha += "</div>";




            int k = 0;


            linha += "<div class='row'>";
            linha += "<div class='col-lg-12'>";
            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";

            linha += "<div class='panel-heading'>";
            linha += "<h4 class='panel-title'>CrossDocking EvoluSom</h4>";
            linha += "</div>";

            linha += "<div class='panel-body'>";

            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>PRODUTO ID</th>";
            linha += "<th>MARCA</th>";
            linha += "<th>UNIDADE</th>";
            linha += "<th>CATEGORIA</th>";
            linha += "<th>QTDE-DISPONÍVEL</th>";
            linha += "<th>GARANTIA (MÊS)</th>";
            linha += "<th>PREÇO</th>";
            linha += "<th>COM ST</th>";
            linha += "</tr>";
            linha += "</thead>";


            linha += "<tfoot>";
            linha += "<tr>";
            linha += "<th>PRODUTO ID</th>";
            linha += "<th>MARCA</th>";
            linha += "<th>UNIDADE</th>";
            linha += "<th>CATEGORIA</th>";
            linha += "<th>QTDE-DISPONÍVEL</th>";
            linha += "<th>GARANTIA (MÊS)</th>";
            linha += "<th>PREÇO</th>";
            linha += "<th>COM ST</th>";
            linha += "</tr>";
            linha += "</tfoot>";
            linha += "<tbody>";



            foreach(DataRow row in dtAldo.Rows) {



                linha += "<tr>";
                linha += "<td>" + row["codigo"].ToString() + "</td>";
                linha += "<td>" + row["marca"].ToString() + "</td>";
                linha += "<td>" + row["unidade"].ToString() + "</td>";
                linha += "<td>" + row["categoria"].ToString() + "</td>";
                linha += "<td>" + row["disponivel"].ToString() + "</td>";
                linha += "<td>" + row["tempo_garantia"].ToString() + "</td>";
                linha += "<td>R$ " + row["preco"].ToString() + "</td>";
                linha += "<td>" + row["precocomst"].ToString() + "</td>";
                linha += "</tr>";

                /*
                 * codigo, marca, categoria, descricao, unidade, multiplo, preco, precoeup, peso, descrecao_tecnica, disponivel,
                 * ipi, dimensoes, abtn, ncm, origem, ppb, portariappb, icms, reducao, precocomst, foto, descricao_amigavel, categoria_ti, 
                 * tempo_garantia, tempo_garantia, procedimentos_rma, link_youtube, emp_filial, mostrar_internet, associados
                 */

                k++;
            }




            linha += "</tbody>";

            linha += "</table>";
            linha += "</div>";
            linha += "</div>";

            linha += "</div>";
            linha += "</div>";




            dtAldo.Dispose();
            dtAldo.Dispose();
            dtAldo.Dispose();

            return linha;

        }


        public string ReadXmlDataSetEvoluSom(string pathXml, string linha) {
            DataSet ds = new DataSet();
            ds.ReadXml(pathXml);

            /* 
            * DataSet que guarda as Informações/Attibutes 
            * da Tabela (DataTable) CrossDoking, extraída do XML.
            */
            DataTable dtEvoluSom = new DataTable();
            dtEvoluSom = ds.Tables["produto"];

            // tem 3 tabelas {produto}, {tabela_precos}, {tabela_preco}


            linha += "<div class='col-lg-12'>";
            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";
            linha += "<table class='table table-striped table-bordered' cellspacing='0' width='100%'>";

            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>CUSTOMER ID</th>";
            linha += "<th>COMPANY</th>";
            linha += "<th>DATABASE</th>";
            linha += "<th>Nº REGISTROS</th>";
            linha += "</tr>";
            linha += "</thead>";

            linha += "<tr>";
            linha += "<td>" + "Cooperchip" + "</td>";
            linha += "<td>" + "EvoluSom" + "</td>";
            linha += "<td>" + "20/04/2015" + "</td>";
            linha += "<td>" + dtEvoluSom.Rows.Count + "</td>";
            linha += "</tr>";

            linha += "</table>";
            linha += "</div>";
            linha += "</div>";




            int k = 0;


            linha += "<div class='row'>";
            linha += "<div class='col-lg-12'>";
            linha += "<div class='panel panel-default toggle panelMove panelClose panelRefresh'>";

            linha += "<div class='panel-heading'>";
            linha += "<h4 class='panel-title'>CrossDocking Aldo</h4>";
            linha += "</div>";

            linha += "<div class='panel-body'>";

            linha += "<table id='tabletools' class='table table-striped table-bordered' cellspacing='0' width='100%'>";
            linha += "<thead>";
            linha += "<tr>";
            linha += "<th>PRODUTO ID</th>";
            linha += "<th>TÍTULO</th>";
            linha += "<th>CATEGORIA</th>";
            linha += "<th>SALDO DISP.</th>";
            linha += "<th>PREÇO</th>";
            linha += "<th>ST</th>";
            linha += "</tr>";
            linha += "</thead>";


            linha += "<tfoot>";
            linha += "<tr>";
            linha += "<th>PRODUTO ID</th>";
            linha += "<th>TÍTULO</th>";
            linha += "<th>CATEGORIA</th>";
            linha += "<th>SALDO DISP.</th>";
            linha += "<th>PREÇO</th>";
            linha += "<th>ST</th>";
            linha += "</tr>";
            linha += "</tfoot>";
            linha += "<tbody>";



            foreach(DataRow row in dtEvoluSom.Rows) {



                linha += "<tr>";
                linha += "<td>" + row["codigo"].ToString() + "</td>";
                linha += "<td>" + row["titulo"].ToString() + "</td>";
                linha += "<td>" + row["categoria"].ToString() + "</td>";
                linha += "<td>" + row["saldo"].ToString() + "</td>";
                linha += "<td>R$ " + row["preco"].ToString() + "</td>";
                linha += "<td>" + row["produtocomst"].ToString() + "</td>";
                linha += "</tr>";

                /*
                 * codigo, codbarra, marca, categoria, titulo, nome_nota, unidade, multiplo, preco, peso, descrecao_tecnica, estoque,
                 * saldo, ipi, altura, largura, comprimento, ncm, origem, ppb, produtocomst, icms, foto, descricao_tecnica, produto_id
                 */

                k++;
            }




            linha += "</tbody>";

            linha += "</table>";
            linha += "</div>";
            linha += "</div>";

            linha += "</div>";
            linha += "</div>";




            dtEvoluSom.Dispose();
            dtEvoluSom.Dispose();
            dtEvoluSom.Dispose();

            return linha;

        }



        protected void btnCrossDockingEvoluSom_Click(object sender, EventArgs e) {
            string linha = "";
            string sCaminhoDoArquivo = Server.MapPath("downloads/evolusom.xml");
            lblResult.Text = ReadXmlDataSetEvoluSom(sCaminhoDoArquivo, linha);
        }

        protected void btnCrossDockingHayamax_Click(object sender, EventArgs e) {
            string linha = "";
            string sCaminhoDoArquivo = Server.MapPath("downloads/hayamax.xml");
            lblResult.Text = ReadXmlDataSetHayamax(sCaminhoDoArquivo, linha);
        }


        protected void btnCrossDockingAldo_Click(object sender, EventArgs e) {
            string linha = "";
            string sCaminhoDoArquivo = Server.MapPath("downloads/aldo.xml");
            lblResult.Text = ReadXmlDataSetAldo(sCaminhoDoArquivo, linha);
        }

        protected void btnCrossDockingOderco_Click(object sender, EventArgs e) {

        }

    }
}