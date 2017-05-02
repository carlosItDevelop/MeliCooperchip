<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="view._default" %>

<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <% Server.Execute("head.aspx"); %>

    <body>


        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->



                       <div id="page-header" class="clearfix">
                            <div class="page-header">
                                <h2>Dashboard</h2>
                                <span class="txt">Benvindo ao APIML | Tools</span>
                            </div>


                            <% Server.Execute("boxes-cas.aspx"); %>


                        </div>


                        <!--  div (row) dos quatro quadros: Vendas de hoje, visitas de hoje, perguntas no mês e fatiramento no mês  / -->
                        <div class="row">
                            <div class="col-lg-3 col-md-6 col-sm-6 col-xs-12">
                                <!-- .col-md-3 -->
                                <div class="panel panel-info tile panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Vendas de Hoje</h4>
                                    </div>
                                    <div class="panel-body pt0">
                                        <div class="progressbar-stats-1">
                                            <div class="stats">
                                                <i class="l-ecommerce-cart-content"></i> 
                                                <div class="stats-number" data-from="0" data-to="76">0</div>
                                            </div>
                                            <div class="progress animated-bar flat transparent progress-bar-xs mb10 mt0">
                                                <div class="progress-bar progress-bar-white" role="progressbar" data-transitiongoal="63"></div>
                                            </div>
                                            <div class="comparison">
                                                <p class="mb0"><i class="fa fa-arrow-circle-o-up s20 mr5 pull-left"></i> 10% acima que o mês passado</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>







                            <!-- / .col-md-3 -->
                            <div class="col-lg-3 col-md-6 col-sm-6 col-xs-12">
                                <!-- .col-md-3 -->
                                <div class="panel panel-success tile panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Visitas de Hoje</h4>
                                    </div>
                                    <div class="panel-body pt0">
                                        <div class="progressbar-stats-1">
                                            <div class="stats">
                                                <i class="l-basic-geolocalize-05"></i> 
                                                <div class="stats-number" data-from="0" data-to="2547">0</div>
                                            </div>
                                            <div class="progress animated-bar flat transparent progress-bar-xs mb10 mt0">
                                                <div class="progress-bar progress-bar-white" role="progressbar" data-transitiongoal="86"></div>
                                            </div>
                                            <div class="comparison">
                                                <p class="mb0"><i class="fa fa-arrow-circle-o-up s20 mr5 pull-left"></i> 2% a mais que no último mês</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>


                                                   

                            <!-- / .col-md-3 -->
                            <div class="col-lg-3 col-md-6 col-sm-6 col-xs-12">
                                <!-- .col-md-3 -->
                                <div class="panel panel-danger tile panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Perguntas no mês</h4>
                                    </div>
                                    <div class="panel-body pt0">
                                        <div class="progressbar-stats-1">
                                            <div class="stats">
                                                <i class="l-basic-life-buoy"></i> 
                                                <div class="stats-number" data-from="0" data-to="78">0</div>
                                            </div>
                                            <div class="progress animated-bar flat transparent progress-bar-xs mb10 mt0">
                                                <div class="progress-bar progress-bar-white" role="progressbar" data-transitiongoal="35"></div>
                                            </div>
                                            <div class="comparison">
                                                <p class="mb0"><i class="fa fa-arrow-circle-o-down s20 mr5 pull-left"></i> 2% a menos que o mês anterior</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>



                            <!-- / .col-md-3 -->
                            <div class="col-lg-3 col-md-6 col-sm-6 col-xs-12">
                                <!-- .col-md-3 -->
                                <div class="panel panel-default tile panelClose panelRefresh">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title">Faturamento no mês</h4>
                                    </div>
                                    <div class="panel-body pt0">
                                        <div class="progressbar-stats-1 dark">
                                            <div class="stats">

                                                <!--<i class="l-banknote"></i> -->
                                                
                                                <div class="stats-number money" data-from="0" data-to="24568">0</div>
                                            </div>
                                            <div class="progress animated-bar flat transparent progress-bar-xs mb10 mt0">
                                                <div class="progress-bar progress-bar-white" role="progressbar" data-transitiongoal="55"></div>
                                            </div>
                                            <div class="comparison">
                                                <p class="mb0"><i class="fa fa-arrow-circle-o-down s20 mr5 pull-left"></i> 1% menos que no último mês</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>
                            <!-- / .col-md-3 -->
                        </div>
                        <!-- FIM DA div (row) dos quatro quadros: Vendas de hoje, visitas de hoje, perguntas no mês e fatiramento no mês  / -->
        
        
                        <!-- Início das divs (row) de perguntas e qualificações / -->
                        <div class="row">
                                <div class="col-lg-6 col-md-12">
                                    <!-- col-lg-4 start here -->

                                    <div class="panel panel-default plain toggle panelMove panelClose panelRefresh">
                                        <!-- Start .panel -->
                                        <div class="panel-heading">
                                            <h4 class="panel-title"><i class="fa fa-comments"></i>Últimas qualificações</h4>
                                        </div>
                                        <div class="panel-body">
                                            <ul class="list-group recent-comments">
                                                <li class="list-group-item clearfix comment-success">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/2.jpg" alt="avatar" />--%>
                                                        <img src="images/produto_fake.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Muito boa transação. Excelente produto e ótimo negócio.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 4:24 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>
                                                <li class="list-group-item clearfix comment-default">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/3.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake2.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Bom negócio. Recomendo.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 12:11 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-info">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/4.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake3.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Ítens em perfeito estado. Entrega super-rápida.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 8:17 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-warning">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/5.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake4.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Não realizada, mas a transação teve um bom desfecho.</p>
                                                    <span class="date text-muted small pull-left">Dez 17, 2014, 6:24 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-danger">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/6.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake5.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Negociação sem problemas. Recomendo a todos do Mercadolivre.</p>
                                                    <span class="date text-muted small pull-left">Dez 16, 2014, 1:20 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-info">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/4.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Entrega super-rápida e atendimento de primeira. Gostei muito.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 8:17 pm</span>
                                                    <a href="#" class="see-more small pull-right">Visualizar</a>
                                                </li>

                                            </ul>

                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>



                                <div class="col-lg-6 col-md-12">
                                    <!-- col-lg-4 start here -->

                                    <div class="panel panel-default plain toggle panelMove panelClose panelRefresh">
                                        <!-- Start .panel -->
                                        <div class="panel-heading">
                                            <h4 class="panel-title"><i class="fa fa-comments"></i>Últimas perguntas</h4>
                                        </div>
                                        <div class="panel-body">
                                            <ul class="list-group recent-comments">


                                                <li class="list-group-item clearfix comment-default">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/3.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake2.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Bom negócio. Recomendo.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 12:11 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-success">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/2.jpg" alt="avatar" />--%>
                                                        <img src="images/produto_fake.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Muito boa transação. Excelente produto e ótimo negócio.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 4:24 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>


                                                <li class="list-group-item clearfix comment-danger">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/6.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake5.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Negociação sem problemas. Recomendo a todos do Mercadolivre.</p>
                                                    <span class="date text-muted small pull-left">Dez 16, 2014, 1:20 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-info">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/4.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Entrega super-rápida e atendimento de primeira. Gostei muito.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 8:17 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-warning">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/5.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake4.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Não realizada, mas a transação teve um bom desfecho.</p>
                                                    <span class="date text-muted small pull-left">Dez 17, 2014, 6:24 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>

                                                <li class="list-group-item clearfix comment-info">
                                                    <div class="avatar pull-left mr15">
                                                        <%--<img src="img/avatars/4.jpg" alt="avatar">--%>
                                                        <img src="images/produto_fake3.png" alt="Produto" />
                                                    </div>
                                                    <p class="text-ellipsis"><span class="name strong">Apelido: </span> Ítens em perfeito estado. Entrega super-rápida.</p>
                                                    <span class="date text-muted small pull-left">Dez 18, 2014, 8:17 pm</span>
                                                    <a href="#" class="see-more small pull-right">Responder</a>
                                                </li>


                                            </ul>

                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>


                        </div> 
                        <!-- Fim da linha (row) de qualificações e perguntas/-->        
        
                
                        <!-- Linha das divs (row) de conversoes e qualificações positivas /-->
                        <div class="row">
                            <!-- Start .row -->
                            <div class="col-lg-8 col-md-12 col-sm-12 col-xs-12">
                                <!-- col-lg-8 start here -->
                                <div class="col-lg-9 col-sm-9 col-xs-12 p0">
                                    <!-- col-lg-9 start here -->
                                    <div class="panel panel-default plain btrr0 bbrr0 panelRefresh" data-mh="payments">
                                        <!-- Start .panel -->
                                        <div class="panel-heading">
                                            <h4 class="panel-title"><i class="fa fa-dollar"></i> Conversões</h4>
                                        </div>
                                        <div class="panel-body">
                                            <div id="line-chart-payments" style="width: 100%; height:250px;"></div>
                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>



                                <!-- col-lg-9 end here -->
                                <div class="col-lg-3 col-sm-3 col-xs-12 p0">
                                    <!-- col-lg-3 start here -->
                                    <div class="panel panel-default tile btlr0 bblr0" data-mh="payments">
                                        <!-- Start .panel -->
                                        <div class="panel-body">
                                            <div class="spark clearfix">
                                                <div class="spark-info mb0"><span class="number stats-number s32" data-from="0" data-to="12857">0</span>
                                                </div>
                                                <div class="spark-info mtm5">Total de transações</div>
                                            </div>
                                            <div class="spark clearfix">
                                                <div class="spark-info mb0"><span class="number stats-number s32 color-gray-light" data-from="0" data-to="4578"></span>
                                                </div>
                                                <div class="sparkline spark-payments mt0"></div>
                                                <div class="spark-info">Concretizadas</div>
                                            </div>
                                            <div class="spark clearfix">
                                                <div class="spark-info mb0"><span class="number stats-number s32 color-gray-light" data-from="0" data-to="5241"></span>
                                                </div>
                                                <div class="sparkline spark-payments mt0"></div>
                                                <div class="spark-info">Canceladas</div>
                                            </div>
                                            <div class="db per100">
                                                <a href="#" class="btn btn-info ml20 mt5">Detalhes</a>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>
                                <!-- col-lg-3 end here -->
                            </div>



                            <!-- col-lg-8 end here -->
                            <div class="col-lg-4 col-md-12 col-sm-12 col-xs-12">
                                <!-- col-lg-4 start here -->
                                <div class="panel panel-default plain">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title"><i class="glyphicon glyphicon-user"></i> Qualificações Positivas</h4>
                                    </div>
                                    <div class="panel-body">
                                        <div class="text-center">
                                            <div id="customer-exp" class="custom-progressbar blue" style="width:244px;height:244px;">
                                                <div class="percent">80<span>%</span>
                                                </div>
                                                <div class="description">RECOMENDAM</div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>
                            <!-- col-lg-4 end here -->

                        </div>
                        <!-- End .row -->
                        <!-- fim das Linha (row) das divs de conversoes e qualificações positivas /-->


                        <!-- (row) Últimas vendas e Montly Sales Goals /-->
                        <div class="row">
                            <div class="col-lg-12 col-md-12">
                                <div class="col-lg-6 col-md-6 col-sm-12">

                                            
                                    <div class="panel panel-default plain toggle panelClose panelRefresh tile btrr0 bbrr0">                                            


                                        <div class="panel-heading" style="margin-bottom: 15px;">
                                            <h4 class="panel-title"><i class="glyphicon glyphicon-list-alt"></i> Últimas vendas</h4>
                                        </div>
                                        <div class="panel-body pt0">
                                            <ul class="list-unstyled mb0">
                                                <li class="mb5 pb5 bbdashed">
                                                    <span class="strong">Order ID: </span>
                                                    <span class="color-red">#345675</span> - R$ 176,00 - em: 12-03-2015 11:42:03
                                                </li>
                                                <li class="mb5 pb5 bbdashed">

                                                    <!--
                                                    <span class="strong">New Your:</span> order
                                                    <span class="color-red">#345675</span> - 176$
                                                        -->

                                                    <span class="strong">Order ID: </span> 
                                                    <span class="color-red">#345674</span> - R$ 56,00 - em: 12-03-2015 11:42:03
                                                </li>
                                                <li class="mb5 pb5 bbdashed">
                                                    <span class="strong">Order ID: </span>
                                                    <span class="color-red">#345673</span> - R$ 12,00 - em: 12-03-2015 11:42:03
                                                </li>
                                                <li class="mb5 pb5 bbdashed">
                                                    <span class="strong">Order ID: </span>
                                                    <span class="color-red">#345672</span> - R$ 34,00 - em: 12-03-2015 11:42:03
                                                </li>
                                                <li class="mb5 pb5 bbdashed">
                                                    <span class="strong">Order ID: </span>
                                                    <span class="color-red">#345671</span> - R$ 15,00 - em: 12-03-2015 11:42:03
                                                </li>
                                                <li class="mb5 pb5">
                                                    <span class="strong">Order ID: </span>
                                                    <span class="color-red">#345669</span> - R$ 67,00 - em: 12-03-2015 11:42:03
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>




                                <div class="col-lg-6 col-md-6 col-sm-12">

                                    <div class="panel panel-default plain toggle panelClose panelRefresh">

                                        <div class="panel-heading" style="margin-bottom: 15px;">
                                            <h4 class="panel-title"><i class="l-basic-target"></i> Montly Sales Goals</h4>
                                        </div>
                                        <div class="panel-body">
                                            <div class="row">
                                                <!-- Start .row -->
                                                <div class="col-md-6">
                                                    <ul class="list-unstyled" style="margin-bottom:13px;">
                                                        <li class="mb15">
                                                            <p class="strong mb0">Shirts <span class="text-muted pull-right small">100 of 200 sold</span>
                                                            </p>
                                                            <div class="progress animated-bar progress-bar-sm flat mt0">
                                                                <div class="progress-bar progress-bar-primary" role="progressbar" data-transitiongoal="50"></div>
                                                            </div>
                                                        </li>
                                                        <li class="mb15">
                                                            <p class="strong mb0">Shoes <span class="text-muted pull-right small">150 of 200 sold</span>
                                                            </p>
                                                            <div class="progress animated-bar progress-bar-sm flat mt0">
                                                                <div class="progress-bar progress-bar-danger" role="progressbar" data-transitiongoal="75"></div>
                                                            </div>
                                                        </li>
                                                        <li class="mb15">
                                                            <p class="strong mb0">Watches <span class="text-muted pull-right small">25 of 200 sold</span>
                                                            </p>
                                                            <div class="progress animated-bar progress-bar-sm flat mt0">
                                                                <div class="progress-bar progress-bar-warning" role="progressbar" data-transitiongoal="12"></div>
                                                            </div>
                                                        </li>
                                                        <li>
                                                            <p class="strong mb0">Coats <span class="text-muted pull-right small">195 of 300 sold</span>
                                                            </p>
                                                            <div class="progress animated-bar progress-bar-sm flat mt0">
                                                                <div class="progress-bar progress-bar-success" role="progressbar" data-transitiongoal="66"></div>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="text-center">
                                                        <div id="sales-goal" class="custom-progressbar green pull-left mr15" style="width:150px;height:150px;">
                                                            <div class="percent">470</div>
                                                            <div class="description s14">of 900 sold</div>
                                                        </div>
                                                    </div>
                                                    <div class="custom-progressbar-legend text-center">
                                                        <p class="text-left"><span class="strong">65%</span> Sold</p>
                                                        <p class="text-left"><span class="strong">35% </span> Left</p>
                                                    </div>
                                                </div>
                                            </div>
                                            <!-- End .row -->
                                        </div>
                                    </div>
                                    <!-- End .panel -->
                                </div>
                            </div>
                            <!-- col-lg-8 end here -->
                        </div>
                        <!-- fim da div (row) => Últimas vendas e Montly Sales Goals /-->
        
        
                        <!-- div (row) do mapa de localização das últimas vendas  /-->
                        <div class="row">
                            <div class="col-lg-12">                                       
                                <div class="panel panel-default plain panelRefresh btlr0 bblr0" data-mh="sales-locations">
                                    <!-- Start .panel -->
                                    <div class="panel-heading">
                                        <h4 class="panel-title"><i class="fa l-basic-geolocalize-01"></i> Localização das últimas vendas</h4>
                                    </div>
                                    <div class="panel-body p0">
                                        <div id="world-map" style="width: 100%; height: 250px"></div>
                                    </div>
                                </div>
                                <!-- End .panel -->
                            </div>
                            <!-- col-lg-12 end here -->
                        </div>
                        <!-- fim da div (row) do mapa de localização das últimas vendas  /-->




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
        <script src="js/libs/date.js"></script>
        <script src="plugins/charts/flot/jquery.flot.custom.js"></script>
        <script src="plugins/charts/flot/jquery.flot.pie.js"></script>
        <script src="plugins/charts/flot/jquery.flot.resize.js"></script>
        <script src="plugins/charts/flot/jquery.flot.time.js"></script>
        <script src="plugins/charts/flot/jquery.flot.growraf.js"></script>
        <script src="plugins/charts/flot/jquery.flot.categories.js"></script>
        <script src="plugins/charts/flot/jquery.flot.stack.js"></script>
        <script src="plugins/charts/flot/jquery.flot.orderBars.js"></script>
        <script src="plugins/charts/flot/jquery.flot.tooltip.min.js"></script>
        <script src="plugins/charts/flot/jquery.flot.curvedLines.js"></script>
        <script src="plugins/charts/sparklines/jquery.sparkline.js"></script>
        <script src="plugins/charts/progressbars/progressbar.js"></script>
        <script src="plugins/ui/waypoint/waypoints.js"></script>
        <script src="plugins/ui/weather/skyicons.js"></script>
        <script src="plugins/ui/notify/jquery.gritter.js"></script>
        <script src="plugins/misc/vectormaps/jquery-jvectormap-1.2.2.min.js"></script>
        <script src="plugins/misc/vectormaps/maps/jquery-jvectormap-world-mill-en.js"></script>
        <script src="plugins/misc/countTo/jquery.countTo.js"></script>
        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/dashboard.js"></script>

    </body>
</html>