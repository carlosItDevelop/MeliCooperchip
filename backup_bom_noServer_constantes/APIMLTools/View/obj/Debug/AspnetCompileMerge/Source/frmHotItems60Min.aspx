<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHotItems60Min.aspx.cs" Inherits="View.FrmHotItems60Min" %>




<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>


        <% //Server.Execute("page-nav.aspx"); %>        
        <% Server.Execute("page-mynav.aspx"); %>

        <% Server.Execute("menu_principal.aspx"); %>    <% Server.Execute("sidebar-direito.aspx"); %>
        

            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Hot - 60 Minutos</h2>
                    <span class="txt">HotItems - Últimos 60 Minutos.</span>
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
                                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - <strong>Lista dos Anúncios mais vendidos nos últimos 60 minutos.</strong></h4>
                                    </div>
                                    <div class="panel-body pt0 pb0">






                                        <div style="padding: 10px; margin: 15px 15px;">
                                            <form class="form-inline" role="form" runat="server">
                                                    <label class="control-label" for="">Escolha:  </label>&nbsp;&nbsp;

                                                        <asp:DropDownList CssClass="fancy-select form-control" ID="cboHotItemsCategorias" runat="server">
                                                            <asp:ListItem Value="todas">&lt;&lt;&lt; TODAS &gt;&gt;&gt;</asp:ListItem>
                                                            <asp:ListItem Value="MLB5672">Acessórios para Veículos</asp:ListItem>
                                                            <asp:ListItem Value="MLB1499">Agro, Indústria e Comércio</asp:ListItem>
                                                            <asp:ListItem Value="MLB1071">Animais</asp:ListItem>
                                                            <asp:ListItem Value="MLB1367">Antiguidades</asp:ListItem>
                                                            <asp:ListItem Value="MLB1368">Arte e Artesanato</asp:ListItem>
                                                            <asp:ListItem Value="MLB1384">Bebês</asp:ListItem>
                                                            <asp:ListItem Value="MLB1132">Brinquedos e Hobbies</asp:ListItem>
                                                            <asp:ListItem Value="MLB1430">Calçados, Roupas e Bolsas</asp:ListItem>
                                                            <asp:ListItem Value="MLB1039">Câmeras e Acessórios</asp:ListItem>
                                                            <asp:ListItem Value="MLB1743">Carros, Motos e Outros</asp:ListItem>
                                                            <asp:ListItem Value="MLB1574">Casa, Móveis e Decoração</asp:ListItem>
                                                            <asp:ListItem Value="MLB1051">Celulares e Telefones</asp:ListItem>
                                                            <asp:ListItem Value="MLB1798">Coleções e Comics</asp:ListItem>
                                                            <asp:ListItem Value="MLB5726">Eletrodomésticos</asp:ListItem>
                                                            <asp:ListItem Value="MLB1000">Eletrônicos, Áudio e Vídeo</asp:ListItem>
                                                            <asp:ListItem Value="MLB1276">Esportes e Fitness</asp:ListItem>
                                                            <asp:ListItem Value="MLB3281">Filmes e Seriados</asp:ListItem>
                                                            <asp:ListItem Value="MLB1144">Games</asp:ListItem>
                                                            <asp:ListItem Value="MLB1459">Imóveis</asp:ListItem>
                                                            <asp:ListItem Value="MLB1648">Informática</asp:ListItem>
                                                            <asp:ListItem Value="MLB1182">Instrumentos Musicais</asp:ListItem>
                                                            <asp:ListItem Value="MLB3937">Jóias e Relógios</asp:ListItem>
                                                            <asp:ListItem Value="MLB1196">Livros</asp:ListItem>
                                                            <asp:ListItem Value="MLB1168">Música</asp:ListItem>
                                                            <asp:ListItem Value="MLB1246">Saúde e Beleza</asp:ListItem>
                                                            <asp:ListItem Value="MLB1540">Serviços</asp:ListItem>
                                                            <asp:ListItem Value="MLB1953">Mais Categorias</asp:ListItem>
                                                        </asp:DropDownList>
&nbsp;
                                                    <asp:Button CssClass="btn btn-success ml10" ID="btnEnviar" runat="server" Text=":: Enviar ::" OnClick="btnEnviar_Click" />
                                            </form>
                                        </div>

                                        <div class="panel panel-default plain toggle panelMove panelClose panelRefresh">
                                            <!-- Start .panel -->
                                            <div class="panel-heading white-bg">
                                                <h4 class="panel-title">Tabela:</h4>
                                            </div>
                                            <div class="panel-body table">

                                                    <asp:Label ID="lblResultJSON" runat="server"></asp:Label>

                                            </div>
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
        <script src="plugins/tables/datatables/jquery.dataTables.js"></script>
        <script src="plugins/tables/datatables/dataTables.tableTools.js"></script>
        <script src="plugins/tables/datatables/dataTables.bootstrap.js"></script>
        <script src="plugins/tables/datatables/dataTables.responsive.js"></script>


        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/tables-data.js"></script>
    </body>
</html>
