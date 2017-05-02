<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="view.profile" %>



<!doctype html>
<!--[if lt IE 8]><html class="no-js lt-ie8"> <![endif]-->
<html class="no-js">


    <head>

        <% Server.Execute("head.aspx"); %>

    </head>
    <body>


        <% //Server.Execute("page-nav.aspx"); %>
        <% Server.Execute("page-mynav.aspx"); %>


        <% Server.Execute("menu_principal.aspx"); %>

        <% Server.Execute("sidebar-direito.aspx"); %>

            <div id="page-header" class="clearfix">
                <div class="page-header">
                    <h2>Perfil do Usuário</h2>
                    <span class="txt">Detalhes sobre o usuário.</span>
                </div>


                <% Server.Execute("boxes-cas.aspx"); %>


            </div>

        <!-- .page-content-inner -->  
        <!-- INÍCIO DO CÓDIGO PERSONALIZADO/-->




<!-- Start .row -->
<div class="row">
    <div class="col-lg-6 col-md-6 col-sm-12">
        <!-- col-lg-4 start here -->
        <div class="panel panel-default plain">
            <!-- Start .panel -->
            <div class="panel-heading">
                <h4 class="panel-title bb">Detalhes do peril</h4>
            </div>
            <div class="panel-body">
                <div class="row profile">
                    <!-- Start .row -->
                    <div class="col-md-4">
                        <div class="profile-avatar">
                            <img src="img/avatars/128.jpg" alt="Avatar">
                            <p class="mt10">
                                Online
                                <span class="device">
                <i class="fa fa-mobile s16"></i>
            </span>
                            </p>
                        </div>
                    </div>
                    <div class="col-md-8">
                        <div class="profile-name">
                            <h3>Carlos Alberto</h3>
                            <p class="job-title mb0"><i class="fa fa-building"></i> SEO na Cooperchip Informática</p>
                            <p class="balance">
                                Balanço: <span>R$ 146.000</span>
                            </p>
                            <a href="#" class="btn btn-primary btn-large mr10"> <i class="fa fa-envelope"></i> Enviar email</a>
                            <a href="#" class="btn btn-default btn-alt btn-large"> Ler Notificações</a>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="contact-info bt">
                            <div class="row">
                                <!-- Start .row -->
                                <div class="col-md-4">
                                    <dl class="mt20">
                                        <dt class="text-muted">Telefone</dt>
                                        <dd>(21) 3689-8891</dd>
                                        <dt class="text-muted">Mobile</dt>
                                        <dd>(21) 98786-1071</dd>
                                        <dt class="text-muted">Fax</dt>
                                        <dd>(21) 3689-8996</dd>
                                    </dl>
                                </div>
                                <div class="col-md-8">
                                    <dl class="mt20">
                                        <dt class="text-muted">Email</dt>
                                        <dd>contato.cooperchip@gmail.com</dd>
                                        <dt class="text-muted">Skype</dt>
                                        <dd>carlos.poetarj</dd>
                                    </dl>
                                </div>
                            </div>
                            <!-- End .row -->
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="profile-info bt">
                            <h5 class="text-muted">Informações do Perfil</h5>
                            <p>CEO / Fundador da Cooperchip Comércio de Produtos e Serviços Ltda. Também é o Arquiteto líder do projeto APIML | Tools - Maganement, 
                                que desenvolve soluções personalizadas para gerenciamento de processos através das APIs do Mercadolivre, com 100% de integração com o Marketplace!</p>
                        </div>
                        <div class="profile-tags">
                            <h5 class="text-muted">Tags</h5>
                            <form role="form" class="form-horizontal mb15">
                                <input type="text" value="CEO, Worker" data-role="tagsinput">
                            </form>
                        </div>
                        <div class="social bt">
                            <h5 class="text-muted">Social</h5>
                            <dl class="dl-horizontal mb0">
                                <dt>
                                    <span class="text-muted">
                    <i class="fa fa-facebook-square"></i>
                    Facebook:
                </span>
                                </dt>
                                <dd><a href="https://facebook.com/ShopCooperchip">Shop.Cooperchip</a>
                                </dd>
                                <dt>
                                    <span class="text-muted">
                    <i class="fa fa-twitter"></i>
                    Twitter:
                </span>
                                </dt>
                                <dd><a href="https://twitter.com/ptcooperchip">@ptcooperchip</a>
                                </dd>
                                <dt>
                                    <span class="text-muted">
                    <i class="fa fa-google-plus"></i>
                    Google+:
                </span>
                                </dt>
                                <dd><a href="https://plus.google.com/u/1/+PROJEEMCASpoetarj/">google++</a>
                                </dd>
                                <dt>
                                    <span class="text-muted">
                    <i class="fa fa-linkedin"></i>
                    LinkedIn:
                </span>
                                </dt>
                                <dd><a href="https://www.linkedin.com/profile/view?id=221584014">linked.in</a>
                                </dd>

                            </dl>
                        </div>
                    </div>
                </div>
                <!-- End .row -->
            </div>
        </div>
        <!-- End .panel -->
        <div class="panel panel-default plain">
            <!-- Start .panel -->
            <div class="panel-heading">
                <h4 class="panel-title">User stats</h4>
            </div>
            <div class="panel-body">
                <ul class="progressbars-stats list-unstyled">
                    <li>
                        <div class="progressbar-icon"><i class="glyphicon glyphicon-user"></i> 
                        </div>
                        <span class="progressbar-text">Profile complete</span>
                        <div class="progress animated-bar flat mt0">
                            <div class="progress-bar" role="progressbar" data-transitiongoal="40"></div>
                        </div>
                    </li>
                    <li>
                        <div class="progressbar-icon"><i class="glyphicon glyphicon-comment"></i> 
                        </div>
                        <span class="progressbar-text">Answer to messages</span>
                        <div class="progress animated-bar flat mt0">
                            <div class="progress-bar progress-bar-primary" role="progressbar" data-transitiongoal="83"></div>
                        </div>
                    </li>
                    <li>
                        <div class="progressbar-icon"><i class="glyphicon glyphicon-hdd"></i> 
                        </div>
                        <span class="progressbar-text">Space taken</span>
                        <div class="progress animated-bar flat mt0">
                            <div class="progress-bar progress-bar-danger" role="progressbar" data-transitiongoal="98"></div>
                        </div>
                    </li>
                    <li>
                        <div class="progressbar-icon"><i class="fa fa-pie-chart"></i> 
                        </div>
                        <span class="progressbar-text">Overall</span>
                        <div class="progress animated-bar flat mt0">
                            <div class="progress-bar progress-bar-success" role="progressbar" data-transitiongoal="62"></div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
        <!-- End .panel -->
    </div>
    <!-- col-lg-4 end here -->
    <div class="col-lg-6 col-md-6 col-sm-12">
        <!-- col-lg-4 start here -->
        <div class="tabs mb20">
            <ul id="profileTab" class="nav nav-tabs">
                <li><a href="#overview" data-toggle="tab">Overview</a>
                </li>
                <li class="">
                    <a href="#edit-profile" data-toggle="tab">Edit</a>
                </li>
            </ul>
            <div id="myTabContent" class="tab-content">
                <div class="tab-pane fade active in" id="overview">
                    <h5>Activity feed</h5>
                    <ul class="timeline timeline-icons">
                        <li>
                            <p>
                                <a href="#">Jonathan Smith</a> attached new <a href="#">Arquivo</a>
                                <span class="timeline-icon"><i class="fa fa-file-text-o"></i></span>
                                <span class="timeline-date">Dec 10, 22:00</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">Jonathan Smith</a> make <a href="#">3 comments</a>
                                <span class="timeline-icon"><i class="fa fa-comment"></i></span>
                                <span class="timeline-date">Dec 8, 13:35</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">Jonathan Smith</a> deposit 300$
                                <span class="timeline-icon"><i class="fa fa-money color-green"></i></span>
                                <span class="timeline-date">Dec 6, 10:17</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">Jonathan Smith</a> purchase <a href="#">3 items</a>
                                <span class="timeline-icon"><i class="fa fa-shopping-cart color-red"></i></span>
                                <span class="timeline-date">Dec 5, 04:36</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">1 support </a> request is received from <a href="#">Jonathan Smith</a>
                                <span class="timeline-icon"><i class="fa fa-life-ring color-gray-light"></i></span>
                                <span class="timeline-date">Dec 4, 18:40</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">12 settings </a> are changed from <a href="#">Jonathan Smith</a>
                                <span class="timeline-icon"><i class="glyphicon glyphicon-cog"></i></span>
                                <span class="timeline-date">Dec 3, 23:17</span>
                            </p>
                        </li>
                        <li>
                            <p>
                                <a href="#">Jonathan Smith</a> Altere sua foto
                                <span class="timeline-icon"><i class="l-basic-photo"></i></span>
                                <span class="timeline-date">Dec 2, 05:17</span>
                            </p>
                        </li>
                    </ul>
                    <a href="#" class="btn btn-default timeline-load-more-btn"><i class="fa fa-refresh"></i> veja mais </a>
                </div>
                <div class="tab-pane fade pb0" id="edit-profile">
                    <form class="form-horizontal group-border stripped" role="form">
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Primeiro nome</label>
                            <div class="col-lg-9">
                                <input type="text" class="form-control" id="firstname" name="firstname">
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Sobrenome</label>
                            <div class="col-lg-9">
                                <input type="text" class="form-control" id="lastname" name="lastname">
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Endereço</label>
                            <div class="col-lg-9">
                                <input type="text" class="form-control" id="address" name="address">
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Companhia</label>
                            <div class="col-lg-9">
                                <input type="text" class="form-control" id="company" name="company">
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Informações sobre você</label>
                            <div class="col-lg-9">
                                <textarea name="info" id="info" rows="10" class="form-control"></textarea>
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <label class="col-lg-3 control-label" for="">Visualização pública ?</label>
                            <div class="col-lg-9">
                                <div class="checkbox-custom">
                                    <input type="checkbox" id="public-checkbox">
                                    <label for="public-checkbox"></label>
                                </div>
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group form-group-vertical">
                            <label class="col-lg-3 control-label" for="">Alterar senha</label>
                            <div class="col-lg-9">
                                <input type="password" class="form-control" id="password" name="password">
                                <input type="password" class="form-control" id="password1" name="password1" placeholder="Redigite a senha">
                            </div>
                        </div>
                        <!-- End .form-group  -->
                        <div class="form-group">
                            <div class="col-lg-9 col-lg-offset-3">
                                <a href="#" class="btn btn-primary" type="subimt">Atualizar</a>
                            </div>
                        </div>
                        <!-- End .form-group  -->
                    </form>
                </div>
            </div>
        </div>
        <!-- End .tabs -->
    </div>
    <!-- col-lg-4 end here -->
    <div class="col-lg-6 col-md-6 col-sm-12">
        <!-- col-lg-4 start here -->
        <div class="panel panel-default plain">
            <!-- Start .panel -->
            <div class="panel-heading">
                <h4 class="panel-title">User purchase</h4>
            </div>
            <div class="panel-body">
                <div id="user-purchase-chart" style="width: 100%; height:250px;"></div>
                <div class="row">
                    <!-- Start .row -->
                    <div class="mt20 bt"></div>
                    <div class="col-lg-6 text-center">
                        <!-- col-lg-6 start here -->
                        <h5 class="mt20 mb0">Stats by type</h5>
                        <div id="morris-donut" style="width: 100%; height:180px;"></div>
                    </div>
                    <!-- col-lg-6 end here -->
                    <div class="col-lg-6 text-center">
                        <!-- col-lg-6 start here -->
                        <h5 class="mt20 mb0">Purchase distribution</h5>
                        <div class="canvas-holder mt15">
                            <canvas id="radar-chartjs" height="180"></canvas>
                        </div>
                    </div>
                    <!-- col-lg-6 end here -->
                </div>
                <!-- End .row -->
            </div>
        </div>
        <!-- End .panel -->
    </div>
    <!-- col-lg-4 end here -->
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
        <script src="js/libs/date.js"></script>
        <script src="plugins/charts/sparklines/jquery.sparkline.js"></script>
        <script src="plugins/charts/flot/jquery.flot.custom.js"></script>
        <script src="plugins/charts/flot/jquery.flot.pie.js"></script>
        <script src="plugins/charts/flot/jquery.flot.resize.js"></script>
        <script src="plugins/charts/flot/jquery.flot.time.js"></script>
        <script src="plugins/charts/flot/jquery.flot.growraf.js"></script>
        <script src="plugins/charts/flot/jquery.flot.categories.js"></script>
        <script src="plugins/charts/flot/jquery.flot.stack.js"></script>
        <script src="plugins/charts/flot/jquery.flot.orderBars.js"></script>
        <script src="plugins/charts/flot/jquery.flot.tooltip.min.js"></script>
        <script src="js/libs/raphael.js"></script>
        <script src="plugins/charts/morris/morris.js"></script>
        <script src="plugins/charts/chartjs/Chart.js"></script>
        <script src="plugins/forms/bootstrap-tagsinput/bootstrap-tagsinput.js"></script>
        <script src="plugins/ui/waypoint/waypoints.js"></script>
        <script src="js/jquery.dynamic.js"></script>
        <script src="js/main.js"></script>
        <script src="js/pages/profile.js"></script>
    </body>
</html>