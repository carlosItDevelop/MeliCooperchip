<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="View.Login" %>

<!DOCTYPE html>
<html lang="en">

<% Server.Execute("head.aspx"); %>

<body class="login-page">
    <!-- Start login container -->
    <div class="container login-container">
        <div class="login-panel panel panel-default plain animated bounceIn">
            <!-- Start .panel -->
            <div class="panel-heading">
                <h4 class="panel-title text-center">
                    <img id="logo" src="img/logo-dark.png" alt="APIML | Tools logo">
                </h4>
            </div>
            <div class="panel-body">
                <%--<form class="form-horizontal mt0" action="default.aspx" id="login-form" role="form">--%>
                <form class="form-horizontal mt0" id="loginform" role="form" runat="server">
                    <div class="form-group">
                        <div class="col-lg-12">
                            <div class="input-group input-icon">
                                <span class="input-group-addon"><i class="fa fa-envelope"></i></span>

                                <asp:TextBox ID="txtEmail" class="form-control" value="" placeholder="Seu email ..." runat="server"></asp:TextBox>
                                <%--<input type="text" name="email" id="email" class="form-control" value="" placeholder="Seu email ...">--%>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-12">
                            <div class="input-group input-icon">
                                <span class="input-group-addon"><i class="fa fa-key"></i></span>
                                <asp:TextBox ID="txtSenha" type="password" class="form-control" value="" placeholder="Sua senha" runat="server"></asp:TextBox>
                                <%--<input type="password" name="password" id="password" class="form-control" value="" placeholder="Sua senha">--%>&nbsp;
                                    <asp:Label ID="lblError" runat="server" Style="font-size: 18px; color: #ed5353;"></asp:Label>
                            </div>
                            <span class="help-block text-right"><a href="#">Esqueceu a senha ?</a></span>
                        </div>
                    </div>
                    <div class="form-group mb0">
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-8">
                            <div class="checkbox-custom">
                                <input type="checkbox" name="remember" id="remember" value="option">
                                <label for="remember">Lembrar ?</label>
                            </div>
                        </div>
                        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-4 mb25">                           
                            <asp:Button ID="Button1" class="btn btn-default pull-right" runat="server" Text="Login" OnClick="btnLogin_Click" />
                            <%--<button class="btn btn-default pull-right" type="submit">Login</button>--%>
                        </div>
                    </div>
                </form>
                <%--                    <div class="seperator">
                        <strong>or</strong>
                        <hr>
                    </div>
                    <div class="social-buttons text-center mt5 mb5">
                        <a href="#" class="btn btn-primary btn-alt mr10">Ajuda <i class="fa fa-facebook s20 ml5 mr0"></i></a> 
                        <a href="#" class="btn btn-danger btn-alt ml10">Sign in with <i class="fa fa-google-plus s20 ml5 mr0"></i></a> 
                    </div>--%>
            </div>
            <div class="panel-footer gray-lighter-bg bt">
                <h4 class="text-center"><strong>Não tem uma conta ?</strong>
                </h4>
                <p class="text-center">
                    <a href="register.aspx" class="btn btn-primary">Criar Conta</a>
                </p>
            </div>
        </div>
        <!-- End .panel -->
    </div>
    <!-- End login container -->
    <div class="container">
        <div class="footer">
            <p class="text-center">&copy; 2007 - <%= DateTime.Now.Year.ToString() %>| Copyright Shop.Cooperchip. Todos os direitos reservados !!!</p>
        </div>
    </div>
    <!-- Javascripts -->
    <!-- Important javascript libs(put in all pages) -->
    <script src="http://code.jquery.com/jquery-2.1.1.min.js"></script>
    <script>
        window.jQuery || document.write('<script src="assets/js/libs/jquery-2.1.1.min.js">\x3C/script>')
    </script>
    <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
    <script>
        window.jQuery || document.write('<script src="assets/js/libs/jquery-ui-1.10.4.min.js">\x3C/script>')
    </script>
    <!--[if lt IE 9]>
  <script type="text/javascript" src="js/libs/excanvas.min.js"></script>
  <script type="text/javascript" src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
  <script type="text/javascript" src="js/libs/respond.min.js"></script>
<![endif]-->
    <!-- Bootstrap plugins -->
    <script src="js/bootstrap/bootstrap.js"></script>
    <!-- Form plugins -->
    <script src="plugins/forms/validation/jquery.validate.js"></script>
    <script src="plugins/forms/validation/additional-methods.min.js"></script>
    <!-- Init plugins olny for this page -->
    <script src="js/pages/login.js"></script>
</body>
</html>
