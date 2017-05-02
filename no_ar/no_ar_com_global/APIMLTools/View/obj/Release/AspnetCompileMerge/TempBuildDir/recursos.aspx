<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recursos.aspx.cs" Inherits="view.recursos" %>



<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>


        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->





            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Recursos</h2>
                    <span class="txt">Todos os recursos da API do ML</span>
                </div>


                <% Server.Execute("boxes-cas.aspx"); %>


           </div>


                        <div class="row">
                            <div class="col-lg-12">
                                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                                    <div class="panel-heading">
                                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> Resources Gerais do APIML | Tools - Management</h4>
                                    </div>
                                    <div class="panel-body pt0 pb0">
                                        <div style="padding: 10px; margin: 15px 15px;">



								<form id="APIRecursos" class="form-horizontal group-border stripped" runat="server">

													
											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">GETs (Anúncios): </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">

                                                                <asp:DropDownList ID="cboDestino" runat="server" CssClass="fancy-select1 form-control">
                                                                    <asp:ListItem Value="frmAnunciosPorCategoria">Anúncios Por Categoria</asp:ListItem>
                                                                    <asp:ListItem Value="frmCategoria">Lista de Categorias</asp:ListItem>
                                                                    <asp:ListItem Value="frmAnunciosPorVendedor">Anúncios por Vendedor</asp:ListItem>
                                                                    <asp:ListItem Value="AboutMyItens">Sobre Meus Anúncios</asp:ListItem>
                                                                    <asp:ListItem Value="frmAnuncioPorID">Anúncio Específico por ID</asp:ListItem>
                                                                    <asp:ListItem Value="frmHotItems60Min">Items mais vendidos na Última Hora - (Hot Items)</asp:ListItem>
                                                                    <asp:ListItem Value="frmItensEmDestaque">Ítens em Destaque na Home Page</asp:ListItem>
                                                                    <asp:ListItem Value="frmHotKeyWords">Termos Mais Pesquisados</asp:ListItem>
                                                                </asp:DropDownList>

                                                        </div>
                            <asp:Button ID="btnChamaGetApi" CssClass="btn btn-success ml10" runat="server" OnClick="btnChamaGetApi_Click" Text=":: ENVIAR ::" ToolTip="Consuma os bancos de Dados do MercadoLivre com o Método GET" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->

											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">GETs (Pedidos): </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">

                                                                <asp:DropDownList ID="cboDestino2" runat="server" CssClass="fancy-select1 form-control">
                                                                    <asp:ListItem Value="frmOrder">Pedidos por ID</asp:ListItem>
                                                                    <asp:ListItem Value="frmPedidosRecentes">Pedidos Abertos - Menos de 21 dias E NÃO Qualifcado por ambas as partes</asp:ListItem>
                                                                    <asp:ListItem Value="frmPedidosArquivados">Pedidos Arquivados - Mais de 21 dias ou Qualificados por ambas as partes</asp:ListItem>
                                                                    <asp:ListItem Value="frmPedidosPendentes">Pedidos Pendentes</asp:ListItem>
                                                                    <asp:ListItem Value="frmListaResumidaPedFech21OrNotQualify">Lista Pedidos Fechados -21d. ou NÃO Qualificados pelas 2 partes</asp:ListItem>                                                                    
                                                                </asp:DropDownList>

                                                        </div>
                            <asp:Button ID="btnChamaGetApi2" CssClass="btn btn-success ml10" runat="server" OnClick="btnChamaGetApi2_Click" Text=":: ENVIAR ::" ToolTip="Consuma os bancos de Dados do MercadoLivre com o Método GET" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->

											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">GETs (Listas): </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">

                                                                <asp:DropDownList ID="cboDestino3" runat="server" CssClass="fancy-select1 form-control">
                                                                    <asp:ListItem Value="frmPerguntasAllQuestions">Perguntas dos Meus Anúncios</asp:ListItem>
                                                                    <asp:ListItem Value="frmCategoria">Lista Categoria</asp:ListItem>
                                                                    <asp:ListItem Value="frmListaDeSubCategoriaComQtde">Lista de Sub-Categorias Com Qtde</asp:ListItem>
                                                                    <asp:ListItem Value="frmGetPerfilSellers">Perfil de um Usuário por ID</asp:ListItem>
                                                                    <asp:ListItem Value="frmMostraFretePelasDimensoes">Calcula frete via API pelas Dimensões</asp:ListItem>                                                                    
                                                                    <asp:ListItem Value="frmMostraFreteComAPIPorItem">Calcula frete via API pelo Anúncio</asp:ListItem>                                                                    
                                                                    <asp:ListItem Value="frmTipoPublicidade">Lista Tipo de Publicidade</asp:ListItem>
                                                                    <asp:ListItem Value="frmQualificacaoFeitaERecebida">Qualificação Sobre um Pedido</asp:ListItem>
                                                                    <asp:ListItem Value="frmQualificarUsuarioMenu">Qualificar Pedido - Usuário</asp:ListItem>
                                                                    <asp:ListItem Value="frmHistoricoDePgtos">Consulta / Histórico de Pagamentos</asp:ListItem>
                                                                    <asp:ListItem Value="frmControleDeQualificacao">Controle de Qualificações</asp:ListItem>
                                                                    <asp:ListItem Value="frmListaProdutosComparacao">Lista de Produtos para Comparacao</asp:ListItem>
                                                                </asp:DropDownList>

                                                        </div>
                            <asp:Button ID="btnChamaGetApi3" CssClass="btn btn-success ml10" runat="server" OnClick="btnChamaGetApi3_Click" Text=":: ENVIAR ::" ToolTip="Consuma os bancos de Dados do MercadoLivre com o Método GET" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->

											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">GETs (Outros): </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">

                                                                <asp:DropDownList ID="cboDestino4" runat="server" CssClass="fancy-select1 form-control">
                                                                    <asp:ListItem Value="frmBuscaUserPorNickName">Busca Usuários por Apelido</asp:ListItem>
                                                                    <asp:ListItem Value="frmBuscaProdutosPorNome">Busca Produtos Por Nome</asp:ListItem>
                                                                    <asp:ListItem Value="frmListaPerguntasPendentes">Lista de Perguntas Pendentes</asp:ListItem>
                                                                    <asp:ListItem Value="frmMeusDados">Meus Dados - Perfil no ML</asp:ListItem>
                                                                    <asp:ListItem Value="frmResumo">Meu Resumo Recente no ML</asp:ListItem>
                                                                    <asp:ListItem Value="frmConsultaVisitasPorUsuario">Consulta Visitas por Usuário</asp:ListItem>
                                                                </asp:DropDownList>

                                                        </div>
                            <asp:Button ID="btnChamaGetApi4" CssClass="btn btn-success ml10" runat="server" OnClick="btnChamaGetApi4_Click" Text=":: ENVIAR ::" ToolTip="Consuma os bancos de Dados do MercadoLivre com o Método GET" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->



											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">POST, PUT e DELETE: </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="cboPosts" runat="server" CssClass="fancy-select1 form-control">
                                                                <asp:ListItem Value="frmQualificarUsuarioMenu">Qualificar Um Usuário</asp:ListItem>
                                                                <asp:ListItem Value="frmCriarTestUser">Criar Usuário de Teste</asp:ListItem>
                                                                <asp:ListItem Value="frmPublicarAnuncio">Publicar Novo Anúncio</asp:ListItem>
                                                            </asp:DropDownList>


                                                        </div>
                            <asp:Button CssClass="btn btn-success ml10" ID="btnChamaPostApi" runat="server" Text=":: ENVIAR ::"  ToolTip="Métodos: POST's, PUT's e DELETE's - Perguntas, Qualificações, Bloqueios, etc." OnClick="btnChamaPostApi_Click" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->

											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">OUTROS: </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="cboDbRelats" runat="server" CssClass="fancy-select1 form-control">
                                                                <asp:ListItem Value="posts">Escolha Uma Opção</asp:ListItem>
                                                                <asp:ListItem Value="frmLerXML">Ler XML Shared stock</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </div>
                          <asp:Button CssClass="btn btn-success ml10" ID="btnEstatistica" runat="server" Text=":: ENVIAR ::"  ToolTip="Consulte dados Estatísticos em Seu Banco de Dados e Liste Relatórios" OnClick="btnEstatistica_Click" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->		

											<!-- End .form-group  -->
                                            <div class="form-group">
                                                <label class="col-lg-2 col-md-3 control-label" for="">NOTIFICAÇÕES: </label>
                                                <div class="col-lg-10 col-md-9">
                                                    <div class="row">
                                                        <!-- Start .row -->

                                                        <div class="col-md-8">
                                                            <asp:DropDownList ID="DDLSimulaNotificacoes" runat="server" CssClass="fancy-select1 form-control">
                                                                <asp:ListItem Value="SetPostForRecebeNotificacoes">Simula notificação MercadoLivre</asp:ListItem>
                                                                <asp:ListItem Value="SetPostForRecebeNotificacoesMP">Simula notificação MercadoPago</asp:ListItem>
                                                            </asp:DropDownList>
                                                        </div>
                          <asp:Button CssClass="btn btn-success ml10" ID="btnSimulaNotify" runat="server" Text=":: ENVIAR ::"  ToolTip="Consulte dados Estatísticos em Seu Banco de Dados e Liste Relatórios" OnClick="btnSimulaNotify_Click" />
                                                    </div>
                                                    <!-- End .row -->
                                                </div>
                                            </div>
                                            <!-- End .form-group  -->		


                                                                                                                                                                           								
								</form>


                                        </div>
                                </div>
                            </div>
                        </div>
                    </div>




        <!-- FIM PARA ESTA PÁGINA SER BLANK MESMO, DEVEMOS TIRAR ESTE CONTEÚDO INTERNO /-->






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
    </body>
</html>