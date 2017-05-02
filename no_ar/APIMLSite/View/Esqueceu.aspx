<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Esqueceu.aspx.cs" Inherits="SimpleMembershipLocalDatabase.Esqueceu" %>




<!doctype html>
<html class="fixed">
	
<!-- Mirrored from preview.oklerthemes.com/porto-admin/1.4.0/pages-recover-password.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 13 Apr 2015 00:25:02 GMT -->
<head>

		<!-- Basic -->
		<meta charset="utf-8" />
		<title>APIML | Tools - Management (Recuperar Senha)</title>		
		<meta name="keywords" content="HTML5 Template,  100% utilizada neste gerenciador de vendas do Mercadolivre" />
		<meta name="description" content="Sistema gerenciador de vendas no Mercadolivre, utilizando suas API (s)" />
		<meta name="author" content="shopcooperchip.com.br Carlos Alberto dos Santos PoetaRJ" />

		<!-- Mobile Metas -->
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />

		<!-- Web Fonts  -->
		<link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800|Shadows+Into+Light" rel="stylesheet" type="text/css">

		<!-- Vendor CSS -->
		<link rel="stylesheet" href="assets/vendor/bootstrap/css/bootstrap.css" />

		<link rel="stylesheet" href="assets/vendor/font-awesome/css/font-awesome.css" />
		<link rel="stylesheet" href="assets/vendor/magnific-popup/magnific-popup.css" />
		<link rel="stylesheet" href="assets/vendor/bootstrap-datepicker/css/datepicker3.css" />

		<!-- Theme CSS -->
		<link rel="stylesheet" href="assets/stylesheets/theme.css" />

		<!-- Theme Custom CSS -->
		<link rel="stylesheet" href="assets/stylesheets/theme-custom.css">

		<!-- Head Libs -->
		<script src="assets/vendor/modernizr/modernizr.js"></script>
	</head>
	<body>
		<!-- start: page -->
		<section class="body-sign">
			<div class="center-sign">
				<a href="#" runat="server" class="logo pull-left">
					<img src="img/logo.png" height="54" alt="APIML | Tools" />
				</a>

				<div class="panel panel-sign">
					<div class="panel-title-sign mt-xl text-right">
						<h2 class="title text-uppercase text-bold m-none"><i class="fa fa-user mr-xs"></i> Recuperar Senha</h2>
					</div>
					<div class="panel-body">
						<div class="alert alert-info">
							<p class="m-none text-semibold h6">Informe seu nome de usuário no campo a seguir e clique no botão 
            <b>Solicitar Nova Senha</b> para enviarmos uma mensagem com as 
            instruções de redefinição de senha para seu e-mail!</p>
						</div>

						<form runat="server">
							<div class="form-group mb-none">
								<div class="input-group">
								    
                                    <asp:TextBox runat="server" ID="txtUsuario" TextMode="Email" CssClass="form-control input-lg" placeholder="Usuário/e-mail" />                                    
									<span class="input-group-btn">

                                        <asp:LinkButton Text="Solicitar Nova Senha" runat="server" ID="btnSolicitar" CssClass="btn btn-primary btn-lg" OnClick="btnSolicitar_Click" />

									</span>
								</div>
							</div>
                                                       
							<p class="text-center mt-lg"> <a href="/Default.aspx">Voltar ao início</a>

						</form>
					</div>
				</div>

				<p class="text-center text-muted mt-md mb-md">&copy; Copyright <%=DateTime.Now.Year.ToString() %>. All Rights Reserved.</p>
			</div>
		</section>
		<!-- end: page -->

		<!-- Vendor -->
		<script src="assets/vendor/jquery/jquery.js"></script>		<script src="assets/vendor/jquery-browser-mobile/jquery.browser.mobile.js"></script>		<script src="assets/vendor/jquery-cookie/jquery.cookie.js"></script>		<script src="assets/vendor/style-switcher/style.switcher.js"></script>		<script src="assets/vendor/bootstrap/js/bootstrap.js"></script>		<script src="assets/vendor/nanoscroller/nanoscroller.js"></script>		<script src="assets/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>		<script src="assets/vendor/magnific-popup/magnific-popup.js"></script>		<script src="assets/vendor/jquery-placeholder/jquery.placeholder.js"></script>
		
		<!-- Theme Base, Components and Settings -->
		<script src="assets/javascripts/theme.js"></script>
		
		<!-- Theme Custom -->
		<script src="assets/javascripts/theme.custom.js"></script>
		
		<!-- Theme Initialization Files -->
		<script src="assets/javascripts/theme.init.js"></script>
		<!-- Analytics to Track Preview Website -->		<script>		  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){		  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),		  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)		  })(window,document,'script','../../../www.google-analytics.com/analytics.js','ga');		  ga('create', 'UA-42715764-8', 'auto');		  ga('send', 'pageview');		</script>
	</body>

<!-- Mirrored from preview.oklerthemes.com/porto-admin/1.4.0/pages-recover-password.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 13 Apr 2015 00:25:02 GMT -->
</html>