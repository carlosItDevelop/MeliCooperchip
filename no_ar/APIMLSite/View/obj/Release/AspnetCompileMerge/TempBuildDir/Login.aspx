<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SimpleMembershipLocalDatabase.pages_signin" %>





<!doctype html>
<html class="fixed">
	
<!-- Mirrored from preview.oklerthemes.com/porto-admin/1.4.0/pages-signin.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 13 Apr 2015 00:24:58 GMT -->
<head>

		<!-- Basic -->
		<meta charset="utf-8" />
		<title>APIML | Tools - Management (Login)</title>		
		<meta name="keywords" content="HTML5 Template,  100% utilizada neste gerenciador de vendas do Mercadolivre" />
		<meta name="description" content="Sistema gerenciador de vendas no Mercadolivre, utilizando suas API (s)" />
		<meta name="author" content="shopcooperchip.com.br Carlos Alberto dos Santos PoetaRJ" />

		<!-- Mobile Metas -->
		<meta name="viewport" content="width=device-width, initial-scale=1.0" />

		<!-- Web Fonts  -->
		<link href="http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700,800|Shadows+Into+Light" rel="stylesheet" type="text/css" />

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
				<a href="Default.aspx" class="logo pull-left">
					<img src="img/logo.png" height="54" alt="APIML | Tools - Management" />
				</a>

				<div class="panel panel-sign">
					<div class="panel-title-sign mt-xl text-right">
						<h2 class="title text-uppercase text-bold m-none"><i class="fa fa-user mr-xs"></i> Sign In</h2>
					</div>
					<div class="panel-body">
						<form action="#" method="post" runat="server">
							<div class="form-group mb-lg">
								<label>Usuário / E-Mail</label>
								<div class="input-group input-group-icon">
								    <asp:TextBox runat="server" ID="txtUsuario" TextMode="Email" CssClass="form-control input-lg" placeholder="Usuário/e-mail" />

									<span class="input-group-addon">
										<span class="icon icon-lg">
											<i class="fa fa-user"></i>
										</span>
									</span>
								</div>
							</div>

							<div class="form-group mb-lg">
								<div class="clearfix">
									<label class="pull-left">Senha</label>
                                    
                                    <!-- Implementar/-->
                                    <%--<a href="/Esqueceu.aspx">Esqueci minha senha</a>--%>
                                    <!-- Implementar e apagar a linha abaixo/-->

									<a href="/Esqueceu.aspx" class="pull-right">Esqueceu a senha?</a>
								</div>
								<div class="input-group input-group-icon">
								    <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" CssClass="form-control input-lg" placeholder="Senha" />
									
									<span class="input-group-addon">
										<span class="icon icon-lg">
											<i class="fa fa-lock"></i>
										</span>
									</span>
								</div>
							</div>

							<div class="row">
								<div class="col-sm-8">
									<div class="checkbox-custom checkbox-default">
                                        <label>
                                            <asp:CheckBox runat="server" ID="chkLembrar"/> Lembrar de mim
                                        </label>
									</div>
								</div>
								<div class="col-sm-4 text-right">
								    <!-- conjunto de dois botoes, que ainda não sei porque /-->
                                    <asp:LinkButton Text="Entrar" runat="server" ID="btnEntrar" CssClass="btn btn-primary hidden-xs" OnClick="btnEntrar_Click"/>                                    
									<button type="button" class="btn btn-primary btn-block btn-lg visible-xs mt-lg">Sign In</button>
								    <!-- fim do conjunto de dois botoes, que ainda não sei porque /-->
								</div>
							</div>

							<span class="mt-lg mb-lg line-thru text-center text-uppercase">
								<span> ajustes </span>
							</span>

							<div class="mb-xs text-center">
								<a href="/Esqueceu.aspx" class="btn btn-facebook mb-md ml-xs mr-xs">Esqueci a senha <i class="fa fa-bug"></i></a>
								<a href="/Default.aspx" class="btn btn-twitter mb-md ml-xs mr-xs">Voltar ao início <i class="fa fa-arrow-circle-o-left"></i></a>
							</div>

							<p class="text-center">Ainda não tem uma conta? <a href="pages_signup.aspx">Registre-se!</a>

						</form>
					</div>
				</div>

				<p class="text-center text-muted mt-md mb-md">&copy; Copyright <%=DateTime.Now.Year.ToString() %>. Todos os direitos reservados.</p>
			</div>
		</section>
		<!-- end: page -->
        
        <%--Esta é uma janela para exibir alertas que usa a função modal() do Bootstrap--%>
        <div class="modal fade" id="divAlert" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        <h4 class="modal-title">
                            <span class="icon-stack">
                                <i class="icon-sign-blank icon-stack-base"></i>
                                <i class="icon-info icon-light"></i>
                            </span>
                            Informação
                        </h4>
                    </div>
                    <div class="modal-body">
                        <% if (Session["alert"] != null)
                           { %>
                        <%: Session["alert"].ToString() %>
                        <% } %>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>        
        
        <script src="/Scripts/jquery-1.9.1.min.js"></script>
        <script src="/Scripts/bootstrap.min.js"></script>
        <script src="/Scripts/scripts.js"></script>
        
        
        <% if (Session["alert"] != null)
           { %>
        <script>
            $(function () {
                $("#divAlert").modal();
            });
        </script>
        <% Session["alert"] = null; %>
        <% } %>        


		<!-- Vendor -->
		<script src="assets/vendor/jquery/jquery.js"></script>		
        <script src="assets/vendor/jquery-browser-mobile/jquery.browser.mobile.js"></script>		
        <script src="assets/vendor/jquery-cookie/jquery.cookie.js"></script>		
        <script src="assets/vendor/style-switcher/style.switcher.js"></script>		
        <script src="assets/vendor/bootstrap/js/bootstrap.js"></script>		
        <script src="assets/vendor/nanoscroller/nanoscroller.js"></script>		
        <script src="assets/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js"></script>		
        <script src="assets/vendor/magnific-popup/magnific-popup.js"></script>		
        <script src="assets/vendor/jquery-placeholder/jquery.placeholder.js"></script>
		
		<!-- Theme Base, Components and Settings -->
		<script src="assets/javascripts/theme.js"></script>
		
		<!-- Theme Custom -->
		<script src="assets/javascripts/theme.custom.js"></script>
		
		<!-- Theme Initialization Files -->
		<script src="assets/javascripts/theme.init.js"></script>
		
	</body>
</html>