<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMostraFreteComAPIPorItem.aspx.cs" Inherits="View.FrmMostraFreteComApiPorItem" %>

<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>

     
        <% Server.Execute("page-mynav.aspx"); %>

        <% Server.Execute("menu_principal.aspx"); %>    <% Server.Execute("sidebar-direito.aspx"); %>
        

            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Calcula Frete Pelo Anúncio</h2>
                    <span class="txt">Resource de cálculo de fretes via api pelo Anúncio.</span>
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
                            <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - Cálculo de frete pelo Anúncio</h4>
                        </div>
                        <div class="panel-body pt0 pb0">
                            <div style="padding: 10px; margin: 10px;">




                                <div class="panel panel-default plain toggle panelMove panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading white-bg">
                                        <h4 class="panel-title">Tabela de Frete:</h4>
                                    </div>
                                    <div class="panel-body table">

                                        <div class="panel plain toggle">
                                        <form id="calculafrete" runat="server"> 

                                                <table class="table col-lg-6">
                                                    <tbody>
                                                        <tr style="text-align: left;"><th>CEP de destino:</th></tr>                                                            
                                                        <tr>
                                                            <td>
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtCEPDestino" runat="server" class="form-control" readonly ></asp:TextBox>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr style="text-align: left;"><th>Endereço de Entrega: </th></tr>                                                            
                                                        <tr>
                                                            <td>
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtEndereco" rows="6" runat="server" TextMode="MultiLine" class="form-control limitTextarea" readonly ></asp:TextBox>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr style="text-align: left;"><th>Detalhes do Frete: </th>
                                                        <tr>
                                                            <td>
                                                                <div class="form-group">
                                                                    <asp:TextBox ID="txtDetalhes" rows="8" runat="server" TextMode="MultiLine" class="form-control limitTextarea" readonly ></asp:TextBox>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    
                                                    </tbody>
                                                </table>

                                        </form> 
                                        </div>
                                        
                                    </div>
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


