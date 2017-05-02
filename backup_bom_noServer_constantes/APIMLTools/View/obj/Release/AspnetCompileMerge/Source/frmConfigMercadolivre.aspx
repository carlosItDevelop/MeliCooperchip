<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmConfigMercadolivre.aspx.cs" Inherits="view.frmConfigMercadolivre" %>





<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <head>

        <% Server.Execute("head.aspx"); %>

    </head>
    <body>


        <% //Server.Execute("page-nav.aspx"); %>
        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

        <div id="page-header" class="clearfix">
            <div class="page-header">
                <h2>Config Mercadolivre</h2>
                <span class="txt">Configurações da API e Layout.</span>
            </div>


            <% Server.Execute("boxes-cas.aspx"); %>


        </div>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->




        <div class="content">
            <div class="row">
                <div class="col-lg-12">
                    <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                        <div class="panel-heading">
                            <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - Management</h4>
                        </div>
                        <div class="panel-body pt0 pb0">

                        <!-- AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                        <!-- AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                        <!-- AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->


                        <div class="panel-heading">
                            <h4 class="panel-title">Configurações Iniciais</h4>
                        </div>

                        <div class="panel-body p0">
                            <div class="tabs inside-panel">
                                <ul id="myTab5" class="nav nav-tabs">
                                    <li>
                                        <a href="#apiml" data-toggle="tab"><i class="fa fa-sitemap"></i>  API Mercadolivre</a>
                                    </li>
                                    <li class="">
                                        <a href="#dadosanuncio" data-toggle="tab"><i class="fa fa-edit"></i>  Dados Anúncios</a>
                                    </li>
                                    <li class="">
                                        <a href="#layoutanuncio" data-toggle="tab"><i class="fa fa-photo"></i>  layout Anúncios</a>
                                    </li>

                                    <li class="">
                                        <a href="#status" data-toggle="tab"><i class="fa fa-check"></i>  Status</a>
                                    </li>
                                </ul>
                            </div>
                        </div><!--  FIM do cabeçalho da tabContentMLConfig /-->

                        <div id="tabContentMLConfig" class="tab-content">

                             <div class="tab-pane fade active in" id="apiml">

                                <div class="panel-heading">
                                    <h4 class="panel-title">Configurações da API</h4>
                                </div>

                                <div class="panel-body">

                                        <form class="form-horizontal" role="form">

                                            <div class="form-group">
                                                
                                                <div class="toggle-custom col-md-4">
                                                    <label class="toggle" data-on="ON" data-off="OFF">
                                                        <input type="checkbox" id="chkAtivarAPIdoML" name="chkAtivarAPIdoML" checked>
                                                        <span class="button-checkbox"></span>
                                                    </label>
                                                    <label for="chkAtivarAPIdoML"> Ativar API do Mercadolivre </label>
                                                    <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ligue este controle para ativar a API do Mercadolivre."></i>
                                                </div>


                                                <div class="col-md-3">
                                                    <div class="checkbox-custom ml10">
                                                        <button id="permitirAPI" class="btn btn-primary">Permitir API  </button>
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="É necessário permitir o aplicativo para utilizar a API."></i>
                                                    </div>
                                                </div>

                                            </div>


                                            <div class="form-group"><!--  007 / -->

                                                <div class="col-sm-4">
                                                    <label style="text-align: left;" class="control-label">URL de Retorno</label>
                                                    <input class="form-control" id="txtURLRetorno" type="text" value="" disabled />
                                                </div>

                                                <div class="col-sm-3">
                                                    <label style="text-align: left;" for="inputPassword" class="control-label">Código do APP</label>
                                                    <input class="form-control" id="txtCodigoDoAPP" placeholder="Código do Aplicativo..." type="text" />
                                                </div>

                                            </div><!-- 007  /-->


                                            <div class="form-group"><!--  008 / -->

                                                <div class="col-sm-4">
                                                    <label style="text-align: left;" class="control-label">URL de Notificação</label>
                                                    <input class="form-control" id="txtURLNotificacao" type="text" value="" disabled />
                                                </div>

                                                <div class="col-sm-3">
                                                    <label style="text-align: left;" class="control-label" for="inputPassword">Áreas de Notificações</label>
                                                    <input class="form-control" id="txtAreaNotificacao" type="text" value="orders,items,questions" disabled />
                                                </div>

                                            </div><!-- 008  /-->


                                            <div class="form-group"><!--  009 / -->

                                                <div class="col-sm-7">
                                                    <label style="text-align: left;" class="control-label">Chave Secreta (Secret Key)</label>
                                                    <input class="form-control" id="txtSecretKey" type="text" placeholder="Chave de autenticação..." value="" />
                                                </div>
                                                <label style="text-align: left; margin-left: 12px;" class="control-label">
                                                    *OBS: Deve-se cadastrar uma aplicação neste link: <a href="http://applications.mercadolivre.com.br" target="_blank">
                                                        http://applications.mercadolivre.com.br</a>
                                                </label>

                                            </div><!-- 009  /-->

                                              <div class="form-group">
                                                   <div class="col-lg-7 col-md-7 col-sm-7 col-xs-7 text-right">
                                                       <button type="submit" class="btn btn-default">Salvar</button>
                                                   </div>
                                              </div>                                            

                                                                                
                                     </form>

                               </div> 


                             </div><!--  FIM da Tag configurações do anuncio /-->

                            
                             <div class="tab-pane fade" id="dadosanuncio">

                                <div class="panel-heading">
                                    <h4 class="panel-title">Edição dos items</h4>
                                </div>

                                <div class="panel-body">
                                        <form class="form-horizontal" role="form">

                                            <div class="form-group">
                                                <div class="col-lg-4">
                                                        <div class="checkbox-custom ml10">
                                                            <input type="checkbox" id="chkAdicionarAutomatico">
                                                            <label for="checkbox">Adicionar Automático</label>
                                                        </div>
                                                </div>

                                                <div class="col-lg-4">
                                                        <div class="checkbox-custom ml10">
                                                            <input type="checkbox" id="chkManterEstoquePadrao">
                                                            <label for="checkbox">Manter Estoque Padrão</label>
                                                        </div>
                                                </div>
                                            </div>


                                            <div class="form-group"><!--  001 / -->

                                                <div class="col-sm-4">
                                                    <label style="text-align: left;" class="control-label">Vídeo Youtube (Apenas ID)</label>
                                                    <input class="form-control" id="focusedInput" type="text" placeholder="Digite o ID do vídeo..." value="">
                                                </div>

                                                <div class="col-sm-4">
                                                    <label style="text-align: left;" for="inputPassword" class="control-label">Estoque</label>
                                                    <input class="form-control" id="disabledInput" placeholder="Estoque Padrão..." type="text">
                                                </div>

                                            </div><!-- 001 form-group com os dois primeiros inputs e label acima do input  /-->


                                            <fieldset><!--   002 / -->
                                                <div class="form-group">
                                                        <div class="col-sm-4">
                                                            <label style="text-align: left;" for="cboTabelaDePrecos" class="control-label">Tabela de Preço</label>
                                                            <select id="cboTabelaDePrecos" class="form-control">
                                                                <option>WEB</option>
                                                                <option>Local</option>
                                                            </select>
                                                        </div>
                                                        <div class="col-sm-4">
                                                            <label style="text-align: left;" for="cboTipoDeCompra" class="control-label">Tipo de Compra</label>
                                                            <select id="cboTipoDeCompra" class="form-control">
                                                                <option>Compre Já</option>
                                                                <option>Arremate</option>
                                                            </select>
                                                        </div>
                                                </div>
                                            </fieldset><!-- 002 form-group com os dois primeiros inputs e label acima do input  /-->


                                            <fieldset><!--   003 / -->
                                                <div class="form-group">
                                                        <div class="col-sm-4">
                                                            <label style="text-align: left;" for="cboCondicoesDoItem" class="control-label">Condições do Item</label>
                                                            <select id="cboCondicoesDoItem" class="form-control">
                                                                <option>Novo</option>
                                                                <option>Usado</option>
                                                            </select>
                                                        </div>
                                                        <div class="col-sm-4">
                                                            <label style="text-align: left;" for="cboTipoDeAnuncio" class="control-label">Tipo de Anúncio</label>
                                                            <select id="cboTipoDeAnuncio" class="form-control">
                                                                <option>Diamante sem juros</option>
                                                                <option>Diamante</option>
                                                                <option>Ouro profissional</option>
                                                                <option>Ouro</option>
                                                                <option>Prata</option>
                                                                <option>Bronze</option>
                                                            </select>
                                                        </div>
                                                </div>
                                            </fieldset><!-- 003  /-->


                                            <div class="form-group"><!-- form-group config toggle /-->

                                            <!-- opt Toggle 001 /-->
                                    
                                                <div class="col-lg-4 col-md-4 col-xs-4">

                                                    <!-- OUTROS MEIOS DE PAGAMENTO /-->
                                                    <div style="padding-top: 10px; padding-bottom: 10px;" class="heading">
                                                        <h4 class="panel-title">Outros meios de pagamento</h4>
                                                    </div>


                                                    <div class="toggle-custom">
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkDinheiro" name="chkDinheiro" checked>
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkDinheiro"> Dinheiro </label>                                                                                        
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item o anúncio será publicado com a opção MercadoPago marcada."></i>
                                                    </div>
                                                                                    
                                                    <div class="toggle-custom">                                                                                      
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkCartaoDeCredito" name="chkCartaoDeCredito">
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkCartaoDeCredito"> Cartão de Crédito </label>
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item os novos anúncios serão publicados automaticamente assim que cadastrado no sistema ou importado."></i>
                                                    </div>
                                                                                    
                                                    <div class="toggle-custom">
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkDepositoBancario" name="chkDepositoBancario" checked>
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkDepositoBancario"> Depósito Bancário </label>
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item os novos anúncios serão publicados com a opção de retirada no local."></i>
                                                    </div>

                                                </div>

                                            <!-- FIM do opt Toggle 001/-->


                                            <!-- opt Toggle 002 /-->

                                                <div class="col-lg-4 col-md-4 col-xs-4">

                                                    <!-- OUTROS MEIOS DE PAGAMENTO /-->
                                                    <div style="padding-top: 10px; padding-bottom: 10px;" class="heading">
                                                        <h4 class="panel-title">Demais Configurações</h4>
                                                    </div>


                                                    <div class="toggle-custom">
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkAceitaMP" name="chkAceitaMP" checked>
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkAceitaMP"> Aceita MercadoPago </label>                                                                                        
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item o anúncio será publicado com a opção MercadoPago marcada."></i>
                                                    </div>
                                                                                    
                                                    <div class="toggle-custom">                                                                                      
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkRecadastramentoAutomatico" name="chkRecadastramentoAutomatico">
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkRecadastramentoAutomatico"> Recadastramento Automático </label>
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item os novos anúncios serão publicados automaticamente assim que cadastrado no sistema ou importado."></i>
                                                    </div>
                                                                                    
                                                    <div class="toggle-custom">
                                                        <label class="toggle" data-on="ON" data-off="OFF">
                                                            <input type="checkbox" id="chkRetirarNoLocal" name="chkRetirarNoLocal" checked>
                                                            <span class="button-checkbox"></span>
                                                        </label>
                                                        <label for="chkRetirarNoLocal"> Retirar no local </label>
                                                        <i class="fa fa-question-circle" data-toggle="tooltip" data-placement="right" title="" data-original-title="Ao marcar este item os novos anúncios serão publicados com a opção de retirada no local."></i>
                                                    </div>
                                                </div>   
                                                
                                                <!-- FIM do opt Toggle 002/-->                                                                                                                                                                                                                              

                                          </div><!-- FIM do form-group config toggle /-->   
                                            
                                            
                                          <div class="form-group">
                                               <div class="col-md-8">
                                                   <label for="txtGarantia" id="txtGarantia">Garantia (Somente 250 caracteres)</label>
                                                   <textarea class="form-control" name="textarea" id="textarea" rows="3" placeholder="Digite os termos da garantia..."></textarea>
                                               </div>
                                          </div>

                                          <div class="form-group">
                                               <div class="col-lg-8 col-md-8 col-sm-8 col-xs-8 text-right">
                                                   <button type="submit" class="btn btn-default">Salvar</button>
                                               </div>
                                          </div>                                            
                                              
                                                                                 
                                     </form>
                                </div> 


                             </div><!--  FIM da Tag dados do anuncio /-->


                             <div class="tab-pane fade" id="layoutanuncio">

                                <div class="panel-heading">
                                    <h4 class="panel-title">Layout do Anúncio</h4>
                                </div>

                                <div class="panel-body">

                                    <form class="form-horizontal">
                                        <label class="control-label" for="">Layout (Não adicione IFRAME)</label>
                                        <div class="form-group">
                                            <div class="col-lg-8 col-md-10">
                                                <div id="summernote"></div>
                                            </div>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-lg-8 col-md-10 col-sm-12 col-xs-12 text-right">
                                                <button type="submit" class="btn btn-default">Salvar</button>
                                            </div>
                                        </div>  



                                        <div class="panel-heading">
                                            <h4 class="panel-title">Variáveis - Mercadolivre</h4>
                                        </div>

                                        <div class="form-group">
                                            <div class="col-lg-8 col-md-10 col-sm-12 col-xs-12 text-left">
                                                
                                                <table class="table table-bordered">
                                                    <thead>
                                                        <tr>
                                                            <th>Variável</th>
                                                            <th>Valor</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td><{codProd}></td>
                                                            <td>Código de referência do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{tituloProd}></td>
                                                            <td>Título do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{descricaoProd}></td>
                                                            <td>Todas as descrição do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{imgPrincipalProd}></td>
                                                            <td>Imagem principal do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{imgOutrosProd}></td>
                                                            <td>Outras imagens do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{linkFreteProd}></td>
                                                            <td>Link do frete do produto</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{linkEshop}></td>
                                                            <td>Link da loja no Eshop</td>
                                                        </tr>
                                                        <tr>
                                                            <td><{marca}></td>
                                                            <td>Marca do Produto</td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                
                                            </div>
                                        </div>  

                                    </form>
                                </div>
                                
                             </div><!--  FIM da Tag Layout dos anuncios /-->


                             <div class="tab-pane fade" id="status">
                                <div class="panel-heading">
                                    <h4 class="panel-title">Status da API do ML</h4>
                                </div>


                                <div class="form-group">
                                    
                                    <div class="col-lg-8 col-md-10 col-sm-12 col-xs-12 text-left">
                                                
                                        <h5>Current Performance and Availability Status</h5>
                                        <table class="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Recurso</th>
                                                    <th>Última Atualização</th>
                                                    <th>Tempo de Resposta (avg)</th>
                                                    <th>Uptime (Última 24h.)</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>User</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Shippiments</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Search</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Questions</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Payments</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Orders</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Oauth</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Items</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Feedback</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    
                                  </div>

                                    <div style="margin-top: 30px;" class="col-lg-8 col-md-10 col-sm-12 col-xs-12 text-left">

                                        <div class="heading">
                                            <h4 class="panel-title">Performance corrente de notificações</h4>
                                        </div>
                                                                                        
                                        <table class="table table-bordered">
                                            <thead>
                                                <tr>
                                                    <th>Feed</th>
                                                    <th>Lag</th>
                                                    <th>Última Notificação</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <tr>
                                                    <td>Item</td>
                                                    <td>X</td>
                                                    <td>Y</td>
                                                </tr>
                                                <tr>
                                                    <td>Question</td>
                                                    <td>X</td>
                                                    <td>Z</td>
                                                </tr>
                                                <tr>
                                                    <td>Orders</td>
                                                    <td>Y</td>
                                                    <td>Z</td>
                                                </tr>
                                            </tbody>
                                        </table>

                                    </div>

                                </div>


                            </div><!--  FIM da Tag Status /-->


                        </div><!--  FIM do conteúdo da tabContentMLConfig /-->


                            
                        <!-- FIM - AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                        <!-- FIM - AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                        <!-- FIM - AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->

                      </div>
                    </div>


                </div>
            </div>
        <!-- End .row -->
        </div>
        <!-- End .content -->




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

        <script src="plugins/forms/fancyselect/fancySelect.js"></script>
        <script src="plugins/forms/select2/select2.js"></script>
        <script src="plugins/forms/maskedinput/jquery.maskedinput.js"></script>
        <script src="plugins/forms/dual-list-box/jquery.bootstrap-duallistbox.js"></script>
        <script src="plugins/forms/spinner/jquery.bootstrap-touchspin.js"></script>
        <script src="plugins/forms/bootstrap-datepicker/bootstrap-datepicker.js"></script>
        <script src="plugins/forms/bootstrap-timepicker/bootstrap-timepicker.js"></script>
        <script src="plugins/forms/bootstrap-colorpicker/bootstrap-colorpicker.js"></script>
        <script src="plugins/forms/bootstrap-tagsinput/bootstrap-tagsinput.js"></script>
        <script src="js/libs/typeahead.bundle.js"></script>
        <script src="plugins/forms/summernote/summernote.js"></script>
        <script src="plugins/forms/bootstrap-markdown/bootstrap-markdown.js"></script>
        <script src="plugins/forms/dropzone/dropzone.js"></script>
        <script src="plugins/charts/sparklines/jquery.sparkline.js"></script>
        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/forms-advanced.js"></script>


    </body>
</html>