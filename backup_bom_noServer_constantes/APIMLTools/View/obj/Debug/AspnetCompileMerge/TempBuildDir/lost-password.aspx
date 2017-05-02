﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lost-password.aspx.cs" Inherits="View.LostPassword" %>

<!DOCTYPE html>
<html lang="en">
    <head>
       <meta charset="utf-8">
        <title>Login | APIMLTools - Management</title>
        <!-- Mobile specific metas -->
        <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1 user-scalable=no">
        <!-- Force IE9 to render in normal mode -->
        <!--[if IE]><meta http-equiv="x-ua-compatible" content="IE=9" /><![endif]-->
        <meta name="author" content="Carlos Alberto dos Santos" />
        <meta name="description" content="Gerenciador de Pedidos para o Mercadolivre" />
        <meta name="keywords" content="gerenciador, mercadolivre, marketplace, api, api mercadolivre, mercadopago" />
        <meta name="application-name" content="APIMLTools | Management" />
        <!-- Import google fonts - Heading first/ text second -->
        <link href='http://fonts.googleapis.com/css?family=Quattrocento+Sans:400,700' rel='stylesheet' type='text/css'>
        <!-- Css files -->
        <!-- Icons -->
        <link href="css/icons.css" rel="stylesheet" />
        <!-- Bootstrap stylesheets (included template modifications) -->
        <link href="css/bootstrap.css" rel="stylesheet" />
        <!-- Plugins stylesheets (all plugin custom css) -->
        <link href="css/plugins.css" rel="stylesheet" />
        <!-- Main stylesheets (template main css file) -->
        <link href="css/main.css" rel="stylesheet" />
        <!-- Custom stylesheets ( Put your own changes here ) -->
        <link href="css/custom.css" rel="stylesheet" />
        <!-- Fav and touch icons -->
        <link rel="apple-touch-icon-precomposed" sizes="144x144" href="img/ico/apple-touch-icon-144-precomposed.png" />
        <link rel="apple-touch-icon-precomposed" sizes="114x114" href="img/ico/apple-touch-icon-114-precomposed.png" />
        <link rel="apple-touch-icon-precomposed" sizes="72x72" href="img/ico/apple-touch-icon-72-precomposed.png" />
        <link rel="apple-touch-icon-precomposed" href="img/ico/apple-touch-icon-57-precomposed.png" />
        <link rel="icon" href="img/ico/favicon.ico" type="image/png" />
        <!-- Windows8 touch icon ( http://www.buildmypinnedsite.com/ )-->
        <meta name="msapplication-TileColor" content="#3399cc" />
    </head>
    <body class="login-page">
        <!-- Start login container -->
        <div class="container login-container">
            <div class="login-panel panel panel-default plain animated bounceIn">
                <!-- Start .panel -->
                <div class="panel-heading">
                    <h4 class="panel-title text-center">
                        <img id="logo" src="img/logo-dark.png" alt="APIMLTools | Management logo">
                    </h4>
                </div>
                <div class="panel-body">
                    <form class="form-horizontal mt0" action="login.aspx" id="register-form" role="form">
                        <div class="form-group">
                            <div class="col-lg-12">
                                <div class="input-group input-icon">
                                    <span class="input-group-addon"><i class="fa fa-envelope"></i></span>
                                    <input type="text" name="email" id="email" class="form-control" placeholder="Seu email ...">
                                </div>
                            </div>
                        </div>
                        <div class="form-group mb0">
                            <div class="col-md-12">
                                <button class="btn btn-default" type="submit">Submit</button>
                            </div>
                        </div>
                    </form>
                </div>
                <div class="panel-footer gray-lighter-bg bt">
                    <h4 class="text-center"><strong>Esqueceu sua senha ?</strong>
                    </h4>
                    <p class="text-center">Você receberá uma nova senha em seu e-mail.</p>
                </div>
            </div>
            <!-- End .panel -->
        </div>
        <!-- End login container -->
        <div class="container">
            <div class="footer">
                <p class="text-center">&copy; 2007 - 2014 | Copyright Shop.Cooperchip. Todos os direitos reservados !!!</p>
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