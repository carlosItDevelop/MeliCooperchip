<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutMyItens.aspx.cs" Inherits="view.AboutMyItens" %>




<!doctype html>

<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>


        <% //Server.Execute("page-nav.aspx"); %>
        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->





        <div id="page-header" class="clearfix">
            <div class="page-header">
                <h2>Meus Dados</h2>
                <span class="txt">Dados do meu cadastro</span>
            </div>


            <% Server.Execute("boxes-cas.aspx"); %>


        </div>
        
        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->







        <asp:Label ID="lblResultJSON" runat="server"></asp:Label>









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
