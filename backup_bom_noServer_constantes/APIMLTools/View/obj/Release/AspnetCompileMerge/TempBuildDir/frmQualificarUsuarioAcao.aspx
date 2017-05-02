<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmQualificarUsuarioAcao.aspx.cs" Inherits="view.frmQualificarUsuarioAcao" %>





<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>


        <% //Server.Execute("page-nav.aspx"); %>        
        <% Server.Execute("page-mynav.aspx"); %>

        <% Server.Execute("menu_principal.aspx"); %>
        <% Server.Execute("sidebar-direito.aspx"); %>

            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Qualificação</h2>
                    <span class="txt">Qualificar transações.</span>
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
                                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - <strong>Management</strong></h4>
                                    </div>
                                    <div class="panel-body pt0 pb0">



                                        <div style="padding: 10px; margin: 15px 15px;">

                                            <div class="panel panel-default plain toggle panelMove panelClose panelRefresh">
                                                <!-- Start .panel -->
                                                <div class="panel-heading white-bg">
                                                    <h4 class="panel-title">Qualificar:</h4>
                                                </div>


                                                <!-- Inicio do trecho que tenho de formatar /-->



                                                <div>
                                                    <div>
                                                        <table class="auto-style1">
                                                            <tr>
                                                                <td class="auto-style2">&nbsp;</td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;
                                                                    <br />
                                                                    Usuário:<br />
                                                                    Produto:<br />
                                                                    <br />
                                                                    A Compra foi concretizada:
                                                                    <asp:RadioButtonList ID="optConcretizada" runat="server" Font-Size="XX-Small" Height="12px" Width="32px">
                                                                        <asp:ListItem Value="sim" Selected="True">Sim</asp:ListItem>
                                                                        <asp:ListItem Value="nao">Não</asp:ListItem>
                                                                    </asp:RadioButtonList>
                                                                    <br />
                                            &nbsp;<br />
                                                                    Como Qualifica a Transação: 
                                                                    <asp:RadioButtonList ID="optQualificacao" runat="server" Font-Size="Smaller" Height="14px" Width="32px" >
                                                                        <asp:ListItem Value="positivo" Selected="True">Positivo</asp:ListItem>
                                                                        <asp:ListItem Value="neutro">Neutro</asp:ListItem>
                                                                        <asp:ListItem Value="negativo">Negativo</asp:ListItem>
                                                                    </asp:RadioButtonList>
                                                                    <br />
                                                                    Faça seu comentário sobre a transação:<br />
                                                                    <br />
                                                                    <asp:TextBox ID="txtComentQualify" runat="server" Height="99px" TextMode="MultiLine" Width="494px"></asp:TextBox>
                                                                    <br />
                                                                    <br />
                                                                    <asp:Button ID="btnEnviar" runat="server" Text=".:::  Qualificar  :::." Height="22px" OnClick="btnEnviar_Click" Font-Size="XX-Small" />
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td style="background-color: #99CCFF">&nbsp;</td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                    <asp:Label ID="lblResultJSON" runat="server" Style="text-align: center"></asp:Label>
                                                </div>



                                                <!-- Fim do trecho que tenho de formatar /-->



<%--                                                <div style="margin: 15px;">
                                                    <form class="form-inline" role="form" runat="server">
                                                        <asp:TextBox ID="txtUsuario" class="form-control" runat="server">TODOS</asp:TextBox>
                                                        <asp:Button ID="btnBuscaUsuario" CssClass="btn btn-primary form-control" runat="server" OnClick="btnBuscaUsuario_Click" Text=" Busca por Usuários " />
                                                    </form>
                                                </div>

                                                <div class="panel-body table">
                                                        <asp:Label ID="lblResultJSON" runat="server"></asp:Label>
                                                </div>--%>
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


