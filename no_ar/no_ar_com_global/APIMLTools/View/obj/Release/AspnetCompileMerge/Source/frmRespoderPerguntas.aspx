<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRespoderPerguntas.aspx.cs" Inherits="view.frmRespoderPerguntas" %>




<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>

    
        <% Server.Execute("page-mynav.aspx"); %>

        <% Server.Execute("menu_principal.aspx"); %>
        <% Server.Execute("sidebar-direito.aspx"); %>

            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Perguntas</h2>
                    <span class="txt">Perguntas pendentes...</span>
                </div>


                <% Server.Execute("boxes-cas.aspx"); %>


            </div>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->





        <!-- Start .row -->
        <div class="row">


            <!-- col-lg-12 end here -->
            <div class="col-lg-12">
                <!-- col-lg-12 start here -->
                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                    <!-- Start .panel -->
                    <div class="panel-heading">
                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools -<strong> Perguntas Pendentes</strong></h4>
                    </div>
                    <div class="panel-body pt0 pb0">

                       
                       <div class="content">     
                       <!-- INÍCIO da classe row
                       ================================================== -->

                       <div class="row" style="min-height: 600px;">



                           <!-- INÍCIO do form formQuestions
                           ================================================== -->
                           <form id="formQuestions" role="form" runat="server">

                                      <div class="col-lg-6 col-md-6" style="margin-top: 15px; margin-bottom: 15px;">

                                          
                                       <div class="panel panel-default toggle panelMove panelClose panelRefresh">



                                                <!-- Start .panel -->
                                                <div class="panel-heading">
                                                    <h4 class="panel-title"><i class="fa fa-list-alt"></i> Responder:</h4>
                                                </div>
                                                <div class="panel-body" style="min-height: 570px;">
                                                    <div>
                                                        <asp:Label ID="lblResultJSON" runat="server"></asp:Label>
                                                    </div>

                                                    <br />

                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtPergunta" class="form-control" readonly="true" rows="3" runat="server" TextMode="MultiLine"></asp:TextBox>
                                                    </div>

                                                    <div class="form-group">
                                                        <asp:TextBox ID="txtResposta" class="form-control limitTextarea" maxlength="500" rows="10" runat="server" TextMode="MultiLine" placeholder="Digite a resposta..."></asp:TextBox>
                                                    </div>

                                                    <br />



                                                    <div class="form-group">
                                                        <div class="col-lg-10 col-md-9">
                                                            <div class="toggle-custom">

                                                                <label class="toggle" data-on="ON" data-off="OFF">
                                                                    <input type="checkbox" id="checkbox-toggle" name="checkbox-toggle">
                                                                    <span class="button-checkbox"></span>
                                                                </label>
                                                                <label for="checkbox-toggle">Apagar pergunta ?</label>
                                                            </div>

                                                            <div class="toggle-custom">
                                                                <label class="toggle" data-on="ON" data-off="OFF">
                                                                    <input type="checkbox" id="checkbox-toggle1" name="checkbox-toggle">
                                                                    <span class="button-checkbox"></span>
                                                                </label>
                                                                <label for="checkbox-toggle1">Bloquear usuário para novas perguntas ?</label>
                                                            </div>

                                                            <div class="toggle-custom">
                                                                <label class="toggle" data-on="ON" data-off="OFF">
                                                                    <input type="checkbox" id="checkbox-toggle2" name="checkbox-toggle">
                                                                    <span class="button-checkbox"></span>
                                                                </label>
                                                                <label for="checkbox-toggle2">Bloquear usuário para lances ?</label>
                                                            </div>

                                                        </div>
                                                    </div>

                                                    <br />


                                                    <div class="form-group" style="margin-top: 10px;">
                                                        <asp:Button CssClass="btn btn-success ml10" ID="btnEnviar" runat="server" Text=".:: Salvar ::." OnClick="btnEnviar_Click" />
                                                    </div>

                                                </div>

                                    
                                        </div>
                                      </div>



                                      <div class="col-lg-6 col-md-6" style="margin-top: 15px; margin-bottom: 15px;">

                                          
                                       <div class="panel panel-default toggle panelMove panelClose panelRefresh">



                                                <!-- Start .panel -->
                                                <div class="panel-heading">
                                                    <h4 class="panel-title"><i class="fa fa-list-alt"></i> Dashboard Question:</h4>
                                                </div>
                                                <div class="panel-body" style="min-height: 570px;">



                                                    <!-- Início dos accordions /-->


                                                    <div class="panel-group accordion" id="accordion">


                                                                <div class="panel panel-primary">
                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne2"> Cálculo de Frete</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseOne2" class="panel-collapse collapse in">

                                                                            <div class="panel-body">

                                                                                    <div class="control-group">
                                                                                        <label for="" class="control-label">CEP: </label>
                                                                                        <div class="form-group">
                                                                                            <asp:TextBox ID="txtCep" class="form-control" runat="server" placeholder="Digite seu CEP..."></asp:TextBox>
                                                                                        </div>
                                                                                    </div>
                                                                                    <br />

<%--                                                                                    <div class="controls">
                                                                                        <a href="#freteModal" role="button" data-toggle="modal" class="btn btn-primary">Calcular</a>                                                                                       
                                                                                    </div>  --%>

                                                                                    <div class="control-group" style="margin-bottom: 15px;">
                                                                                        <asp:Button CssClass="btn btn-success ml10" ID="btnCalculaFrete" runat="server" Text=".: Calcular :." OnClick="btnCalculaFrete_Click" />
                                                                                    </div>  

<%--                                                                                    <div class="control-group" style="margin-bottom: 15px;">
                                                                                        <input type="button" class="btn btn-success" ID="btnJavascript" onclick="MostraFrete(); return false;"  value="TesteMetodoJavascrit" />
                                                                                    </div>  --%>

                                                                                

                                                                                    <div class="control-group">
                                                                                        <label for="" class="control-label">Rota do Frete: </label>
                                                                                        <div class="form-group">
                                                                                            <asp:TextBox ID="txtRotaFrete" class="form-control limitTextarea" rows="9" runat="server" TextMode="MultiLine" placeholder="Rotas e tabela de frete..."></asp:TextBox>
                                                                                        </div>                                                                                                
                                                                                    </div>

                                                                                    <div class="control-group" style="margin-top: 10px;">
                                                                                        <button type="button" class="btn btn-primary" data-dismiss="modal" onclick="AdicionaRotaDeFrete();">Adicionar à Resposta</button>
                                                                                    </div>
                                                                                                                                                              
                                                                            </div>                                                                           
                                                                                                                                                        
                                                                            
<%--                                                                            <!-- freteModal --
                                                                            ===================================== -->
                                                                            <div class="modal fade" id="freteModal" tabindex="-1" role="dialog" aria-hidden="true" aria-labelledby="meuLabelHeader">
                                                                                <div class="modal-dialog">
                                                                                    <div class="modal-content">
                                                                                        <div class="modal-header">
                                                                                            <button class="close">x</button>
                                                                                            <h2 id="meuLabelHeader">Cálculo de Frete</h2>
                                                                                        </div>
                                                                                        <div class="modal-body">
                                                                                            
                                                                                            <div class="control-group">
                                                                                                <label for="" class="control-label">Rota do Frete: </label>
                                                                                                <div class="form-group">
                                                                                                    <asp:TextBox ID="txtRotaFrete" class="form-control limitTextarea" rows="10" runat="server" TextMode="MultiLine" placeholder="Rotas e tabela de frete..."></asp:TextBox>
                                                                                                </div>                                                                                                
                                                                                            </div>

                                                                                        </div>
                                                                                        <div class="modal-footer">
                                                                                            <button type="button" class="btn" data-dismiss="modal" onclick="LimpaRotaFrete();">Cancelar</button>
                                                                                            <button type="button" class="btn btn-primary" data-dismiss="modal" onclick="AdicionaRotaDeFrete();">Adicionar à Resposta</button>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                            <!-- Fim do freteModal -->--%>


                                                                        </div>
                                                                </div>


                                                                <div class="panel panel-primary">

                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo"> Dashboard / Perfil do Comprador</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseTwo" class="panel-collapse collapse">
                                                                        <div class="panel-body">
                                                                            
                                                                            <section>
                                                                                <div class="painel-heading">
                                                                                    <h3 class="panel-title">Reputação / Qualificações</h3>
                                                                                </div>
                                                                                <table id="reputacao" class="table">
                                                                                    <thead>                                                                                        
                                                                                        <tr>
                                                                                            <th style="text-align: center;">Positivas</th>
                                                                                            <th style="text-align: center;">Neutras</th>
                                                                                            <th style="text-align: center;">Negativas</th>
                                                                                        </tr>
                                                                                    </thead>
                                                                                    <tbody>
                                                                                        <tr>
                                                                                            <td style="text-align: center;"><button type="button" class="btn btn-sm btn-success btn-round mr5 mb10"><asp:Label runat="server" class="control-label" id="lblPositivas"></asp:Label></button></td>
                                                                                            <td style="text-align: center;"><button type="button" class="btn btn-sm btn-primary btn-round mr5 mb10"><asp:Label runat="server" class="control-label" id="lblNeutras"></asp:Label></button></td>
                                                                                            <td style="text-align: center;"><button type="button" class="btn btn-sm btn-danger btn-round mr5 mb10"><asp:Label runat="server" class="control-label" id="lblNegativas"></asp:Label></button></td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </section>

                                                                            <br />
                                                                            <section>
                                                                                <div class="painel-heading">
                                                                                    <h3 class="panel-title">Índices de Conversão</h3>
                                                                                </div>
                                                                                <table id="conversao" class="table">
                                                                                    <thead>                                                                                        
                                                                                        <tr>
                                                                                            <th style="text-align: center;">Total de Transações</th>
                                                                                            <th style="text-align: center;">Concretizadas</th>
                                                                                            <th style="text-align: center;">Canceladas</th>
                                                                                        </tr>
                                                                                    </thead>
                                                                                    <tbody>
                                                                                        <tr>

                                                                                            <td style="text-align: center;"><asp:Label runat="server" class="control-label" id="lblTotalTransacoes" ></asp:Label></td>
                                                                                            <td style="text-align: center;"><asp:Label runat="server"  class="control-label" id="lblTransacoesConcretizadas" ></asp:Label></td>
                                                                                            <td style="text-align: center;"><asp:Label runat="server"  class="control-label" id="lblTransacoesCanceladas" ></asp:Label></td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </section>


                                                                            <br />
                                                                            <section>
                                                                                <div class="painel-heading">
                                                                                    <h3 class="panel-title">Status do Perfil</h3>
                                                                                </div>
                                                                                <table id="statusUser" class="table">
                                                                                    <thead>                                                                                        
                                                                                        <tr>
                                                                                            <th style="text-align: center;">Pontos no ML</th>
                                                                                            <th style="text-align: center;">Status do Usuário</th>
                                                                                            <th style="text-align: center;">Data Cadastro</th>
                                                                                        </tr>
                                                                                    </thead>
                                                                                    <tbody>
                                                                                        <tr>
                                                                                            <td style="text-align: center;"><asp:Label runat="server"  class="control-label" id="lblPontosNoML" ></asp:Label></td>
                                                                                            <td style="text-align: center;"><asp:Label runat="server"  class="control-label" id="lblStatusDoUsuario" ></asp:Label></td>
                                                                                            <td style="text-align: center;"><asp:Label runat="server"  class="control-label" id="lblDataDoCadastro" ></asp:Label></td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </section>
                                                                        
                                                                        
                                                                        </div>
                                                                    </div>
                                                                </div>


                                                                <div class="panel panel-primary">

                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne"> Saudações e Assinaturas</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseOne" class="panel-collapse collapse">
                                                                        <div class="panel-body">
                                                                            

                                                                            <p>Saudações e assinaturas!</p>


                                                                        </div>
                                                                    </div>
                                                                </div>


                                                                <div class="panel panel-primary">
                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseThree"> Respostas Anteriores</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseThree" class="panel-collapse collapse">
                                                                        <div class="panel-body">
                                                                            
                                                                            <!-- Perguntas e Respostas anteriores
                                                                            -------------------------------------------------------->

                                                                            <section>
                                                                                <div class="panel-heading">
                                                                                    <h3 class="panel-title">Otras perguntas deste vendedor:</h3>
                                                                                </div>
                                                                                <div class="panel-body">

                                                                                    <p>Qtde de Perguntas: <span><asp:Label runat="server" class="control-label" id="lblQtdePerguntas"></asp:Label></span></p>

                                                                                <table id="perguntas_anteriores" class="table">
                                                                                    <thead>                                                                                        
                                                                                        <tr>
                                                                                            <th>Histórico</th>
                                                                                        </tr>
                                                                                    </thead>
                                                                                    <tbody>
                                                                                        <tr>
                                                                                            <td><asp:Label runat="server" class="control-label" id="lblPerguntas"></asp:Label></td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>

                                                                                </div>
                                                                            </section>



                                                                        </div>
                                                                    </div>
                                                                </div>


                                                                <div class="panel panel-primary">
                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseOne1"> Sugestões de Respostas</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseOne1" class="panel-collapse collapse">
                                                                        <div class="panel-body">
                                                                            

                                                                            <p>Sugestões de Respostas!</p>


                                                                        </div>
                                                                    </div>
                                                                </div>


                                                                <div class="panel panel-primary">
                                                                    <div class="panel-heading">
                                                                        <h5 class="panel-title">
                                                                            <a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo1"> Rascunho / Histórico</a>
                                                                        </h5>
                                                                    </div>
                                                                    <div id="collapseTwo1" class="panel-collapse collapse">
                                                                        <div class="panel-body">
                                                                            

                                                                            <div class="form-group">
                                                                                <asp:TextBox ID="txtRascunho" class="form-control limitTextarea" rows="4" runat="server" TextMode="MultiLine" placeholder="Faça anotações para respostas futuras..."></asp:TextBox>
                                                                            </div>


                                                                        </div>
                                                                    </div>
                                                                </div>


                                                    </div>



                                                    <!-- Fim dos accordions /-->




                                                </div>

                                    
                                        </div>
                                      </div>

                                    
                           </form>
                           <!-- FIM do form formQuestions
                           ================================================== -->


                       </div>
                       <!-- FIM da classe row
                       ================================================== -->
                       </div>


                    </div>
                </div>
                <!-- End .panel -->
            </div>
            <!-- col-lg-12 end here -->



        </div>
        <!-- End .row -->



        <!-- FIM DO CÓDIGO PERSONALIZADO/-->
        <!-- / .page-content-inner -->

        <% Server.Execute("nav-inferior.aspx"); %>


        <!-- Javascripts -->
        <!-- Load pace first -->
        <script src="plugins/core/pace/pace.min.js"></script>
        <!-- Important javascript libs(put in all pages) -->
        <script src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
        <script>
            window.jQuery || document.write('<script src="js/libs/jquery-2.1.1.min.js">\x3C/script>')
        </script>
        <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
        <script>
            window.jQuery || document.write('<script src="js/libs/jquery-ui-1.10.4.min.js">\x3C/script>')
        </script>
        <!--[if lt IE 9]>
  <script type="text/javascript" src="js/libs/excanvas.min.js"></script>
  <script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
  <script type="text/javascript" src="js/libs/respond.min.js"></script>
<![endif]-->
        <!-- Bootstrap plugins -->
        <script src="js/bootstrap/bootstrap.js"></script>
        <!-- Core plugins ( not remove ) -->
        <script src="js/libs/modernizr.custom.js"></script>
        <!-- Handle responsive view functions -->
        <script src="js/jRespond.min.js"></script>
        <!-- Custom scroll for sidebars,tables and etc. -->
        <script src="plugins/core/slimscroll/jquery.slimscroll.min.js"></script>
        <script src="plugins/core/slimscroll/jquery.slimscroll.horizontal.min.js"></script>
        <!-- Remove click delay in touch -->
        <script src="plugins/core/fastclick/fastclick.js"></script>
        <!-- Increase jquery animation speed -->
        <script src="plugins/core/velocity/jquery.velocity.min.js"></script>
        <!-- Quick search plugin (fast search for many widgets) -->
        <script src="plugins/core/quicksearch/jquery.quicksearch.js"></script>
        <!-- Bootbox fast bootstrap modals -->
        <script src="plugins/ui/bootbox/bootbox.js"></script>
        <!-- Other plugins ( load only nessesary plugins for every page) -->
        <script src="plugins/charts/sparklines/jquery.sparkline.js"></script>
        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/blank.js"></script>


        <!-- Meus plugins ( load only nessesary ) -->
        <script src="js/apimltools/apimltools-scripts.js" type="text/javascript"></script>


    </body>
</html>







