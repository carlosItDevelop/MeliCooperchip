﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mycomponentes.aspx.cs" Inherits="View.Mycomponentes" %>

<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>


    <body>


        <% //Server.Execute("page-nav.aspx"); %>
        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>    <% Server.Execute("sidebar-direito.aspx"); %>

        

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->





        <div id="page-header" class="clearfix">
            <div class="page-header">
                <h2>Meus Coponentes</h2>
                <span class="txt">Testes de Componentes</span>
            </div>


            <% Server.Execute("boxes-cas.aspx"); %>


        </div>





        <!-- Start .row -->
        <div class="row">
            <div class="col-lg-12">
                <!-- col-lg-12 start here -->
                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                    <!-- Start .panel -->
                    <div class="panel-heading">
                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - Management</h4>
                    </div>
                    <div class="panel-body pt0 pb0">

                    <!-- AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->




                    <h1>Teste de conteúdo genérico!</h1>

                        <br />

                            <!-- col-lg-6 end here -->
                            <div class="col-lg-6">
                                <!-- col-lg-6 start here -->
                                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Sweet Alerts</h4>
                                    </div>
                                    <div class="panel-body">
                                        <table class="table">
                                            <thead>
                                                <tr>
                                                    <th>Description</th>
                                                    <th>Action</th>
                                                    <th>Code</th>
                                                </tr>
                                            </thead>
                                            <tbody>

                                                <tr>
                                                    <td>Exemplo Básico</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-1">Sweet-1</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>

                                                <tr>
                                                    <td>Exemplo com Sweet-2</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-2">Sweet-2</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>

                                                <tr>
                                                    <td>Exemplo com Sweet-3</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-3">Sweet-3</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>
                                                </tr>

                                                <tr>
                                                    <td>Exemplo com Sweet-4</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-4">Sweet-4</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>

                                                <tr>
                                                    <td>Exemplo com Sweet-5</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-5">Sweet-5</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>
 
                                                <tr>
                                                    <td>Exemplo com Sweet-6</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-6">Sweet-6</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>

                                                <tr>
                                                    <td>Exemplo com Sweet-7</td>
                                                    <td><a href="#" class="btn btn-default btn-sm sweet-7">Meu Sweet-7</a>
                                                    </td>
                                                    <td><code></code>
                                                    </td>
                                                </tr>



                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>
                            <!-- col-lg-6 end here -->




                    <!-- FIM - AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                  </div>
                </div>
            </div>
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
        <script src="js/pages/notifications.js"></script>


        <script src="plugins/ui/title-notifier/title_notifier.js"></script>
        <script src="plugins/ui/notify/jquery.gritter.js"></script>
        <script src="plugins/ui/bootstrap-sweetalert/sweet-alert.js"></script>


    </body>
</html>