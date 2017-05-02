<%@ Page Title="" Language="C#" MasterPageFile="~/frontend.Master" AutoEventWireup="true" CodeBehind="nossosPlanos.aspx.cs" Inherits="SimpleMembershipLocalDatabase.nossosPlanos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="frontendContent" runat="server">
    
    
			<div role="main" class="main">

				<section class="page-top">
					<div class="container">
						<div class="row">
							<div class="col-md-12">
								<ul class="breadcrumb">
									<li><a href="#">Home</a></li>
									<li class="active">Nossos Planos</li>
								</ul>
							</div>
						</div>
						<div class="row">
							<div class="col-md-12">
								<h1>Tabela de Preços</h1>
							</div>
						</div>
					</div>
				</section>

				<div class="container">

					<h2><strong>Planos personalizados</strong> para cada caso...</h2>

					<div class="row">
						<div class="col-md-12">
							<p class="lead">
								Além da nossa tabela de preços <span class="alternative-font">escaláveis</span> podemos personalizar um plano exlusivo para seu negócio!.
							</p>
						</div>
					</div>

					<hr class="tall" />

<%--					<h3 class="short"><strong>Four</strong> Plans</h3>
					<p>Using the "Most Popular" css class.</p>--%>

					<div class="row">

						<div class="pricing-table">
						    
                            
							<div class="col-md-3 col-sm-6">
								<div class="plan">
									<h3>Bronze<span>49</span></h3>
									<a class="btn btn-lg btn-primary" href="#">Assinar</a>
									<ul>
										<li><b>Gerenciamento</b> de pedidos</li>
										<li><b>Suporte</b> via chat e telefone</li>
										<li><b>Manual</b> online</li>
										<li><b>Treinamento</b> online</li>
										<li><b>100%</b> online</li>
										<li><b>Setup: R$ 299,90</b> Mensalidade mínima de 49,00 Descontos progressivos a partir de 250 vendas/mês</li>
									</ul>
								</div>
							</div>  
                            
							<div class="col-md-3 col-sm-6">
								<div class="plan">
									<h3>Prata<span>99</span></h3>
									<a class="btn btn-lg btn-primary" href="#">Assinar</a>
									<ul>
										<li><b>Tudo</b> do plano bronze mais...</li>
										<li><b>Bloqueio</b> de duplicadas</li>
										<li><b>Configurador</b> de bloqueios</li>
										<li><b>Qualificador</b> automático</li>
										<li><b>Configurador</b> de qualificações</li>
										<li><b>Setup: R$ 299,90</b> Mensalidade mínima de 99,00 Descontos progressivos a partir de 250 vendas/mês</li>
									</ul>
								</div>
							</div>                                                      
                            
                            
							<div class="col-md-3 col-sm-6 center">
								<div class="plan most-popular">
									<div class="plan-ribbon-wrapper"><div class="plan-ribbon">Popular</div></div>
									<h3>Profissional<span>149</span></h3>
									<a class="btn btn-lg btn-primary" href="#">Assinar</a>
									<ul>
										<li><b>Tudo</b> do plano prata mais...</li>
										<li><b>Controle</b> de concretização</li>
										<li><b>Repositor</b> de unidades</li>
										<li><b>Remoção</b> de contraditórias</li>
										<li><b>Respondedor</b> de perguntas</li>
										<li><b>Setup: R$ 299,90</b> Mensalidade mínima de 149,00 Descontos progressivos a partir de 250 vendas/mês</li>
									</ul>
								</div>
							</div>                            

							<div class="col-md-3 col-sm-6">
								<div class="plan">
									<h3>Enterprise<span>299</span></h3>
									<a class="btn btn-lg btn-primary" href="#">Assinar</a>
									<ul>
										<li><b>Tudo</b> do plano profissional mais...</li>
										<li><b>Estatísticas</b> de venda</li>
										<li><b>Removedor</b> de negativas</li>

										<li><b>Precificador</b> automático</li>
										<li><b>100%</b> online</li>
										<li><b>Setup: R$ 299,90</b> Mensalidade mínima de 299,00 Descontos progressivos a partir de 250 vendas/mês</li>
									</ul>
								</div>
							</div>


						</div>

					</div>

				</div>

			</div>    

</asp:Content>
