<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page-mynav.aspx.cs" Inherits="View.PageMynav" %>



       <!--[if lt IE 9]>
      <p class="browsehappy">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> to improve your experience.</p>
    <![endif]-->
        <!-- .page-navbar -->
        <div id="header" class="page-navbar">
            <!-- .navbar-brand -->
            <a href="default.aspx" class="navbar-brand hidden-xs hidden-sm">
                <img src="/img/logo.png" class="logo hidden-xs" alt="APIML | Tools - logo" />
                <img src="/img/logosm.png" class="logo-sm hidden-lg hidden-md" alt="APIML | Tools - logo" />
            </a>
            <!-- / navbar-brand -->
            <!-- .no-collapse -->
            <div id="navbar-no-collapse" class="navbar-no-collapse">
                <!-- top left nav -->
                <ul class="nav navbar-nav">
                    <li class="toggle-sidebar">
                        <a href="#">
                            <i class="fa fa-reorder"></i>
                            <span class="sr-only">Collapse sidebar</span>
                        </a>
                    </li>
                    <li>
                        <a href="#" class="reset-layout tipB" title="Reseta o painel para esta página."><i class="fa fa-history"></i></a>
                    </li>

                    <li>
                        <a href="/info.asp" class="spark-info spark clearfix"><span class="number">Info</span> System</a>
                    </li>
                    
                    <li>
                        <a href="/frmInfo.aspx" class="spark-info spark clearfix"><span class="number">Constantes</span> System</a>
                    </li>
                                        
                    <li>
                        <a href="#" class="spark-info spark clearfix"><span class="number">Visitar</span> Loja</a>
                    </li>                    

                </ul>
                <!-- / top left nav -->                
                
                
                
                <!-- top right nav -->
                <ul class="nav navbar-nav navbar-right">

                    <li class="dropdown">
                        <a href="#" data-toggle="dropdown">
                            <i class="fa fa-bolt" data-toggle="tooltip" data-placement="bottom" title="Notificações"></i>                            
                            <span class="sr-only">Notificações</span>
                        </a>
                        <ul class="dropdown-menu right dropdown-notification" role="menu">
                            <li><a href="#" class="dropdown-menu-header">Notificações</a>
                            </li>
                            <li><a href="#"><i class="l-basic-life-buoy"></i> Notificações de Questions</a></li>
                            <li><a href="#"><i class="l-basic-gear"></i> Notificações de Items</a></li>
                            <li><a href="#"><i class="l-weather-lightning"></i> Notificações de Orders</a></li>
                            <li><a href="#"><i class="l-basic-server2"></i> Notificações de Peyments</a></li>
                            <li>
                                <a href="#" class="view-all">Ver todos
                                    <i class="l-arrows-right"></i>
                                </a>
                            </li>
                        </ul>
                    </li>


                    <%-- data-toggle="tooltip" data-placement="bottom" title="Tooltip on bottom">--%>

                    <li class="dropdown">
                        <a href="#" data-toggle="dropdown">
                            <i class="fa fa-cubes" data-toggle="tooltip" data-placement="bottom" title="Configurações Gerais"></i>
                            <span class="sr-only">Configurações</span>
                        </a>
                        <ul class="dropdown-menu right dropdown-notification" role="menu">
                            <li><a href="#" class="dropdown-menu-header">Configurações</a></li>
                            <li><a href="/frmConfigMercadolivre.aspx"><i class="l-basic-life-buoy"></i> Configurações do Mercadolivre</a></li>
                            <li><a href="#"><i class="l-basic-gear"></i> Configurações de Usuários</a></li>
                            <li><a href="#"><i class="l-weather-lightning"></i> Configurações de Sistema</a></li>
                        </ul>
                    </li>


                    <li class="dropdown">
                        <a href="#" data-toggle="dropdown">
                            <i class="fa fa-cogs" data-toggle="tooltip" data-placement="bottom" title="Configurações da Template"></i>
                            <span class="sr-only">Settings</span>
                        </a>
                        <ul class="dropdown-menu dropdown-form dynamic-settings right" role="menu">
                            <li><a href="#" class="dropdown-menu-header">Config da template</a>
                            </li>
                            <li>
                                <div class="toggle-custom">
                                    <label class="toggle" data-on="ON" data-off="OFF">
                                        <input type="checkbox" id="fixed-header-toggle" name="fixed-header-toggle" checked>
                                        <span class="button-checkbox"></span>
                                    </label>
                                    <label for="fixed-header-toggle">Cabeçalho fixo</label>
                                </div>
                            </li>
                            <li>
                                <div class="toggle-custom">
                                    <label class="toggle" data-on="ON" data-off="OFF">
                                        <input type="checkbox" id="fixed-left-sidebar" name="fixed-left-sidebar" checked>
                                        <span class="button-checkbox"></span>
                                    </label>
                                    <label for="fixed-left-sidebar">Sidebar esquerda fixa</label>
                                </div>
                            </li>
                            <li>
                                <div class="toggle-custom">
                                    <label class="toggle" data-on="ON" data-off="OFF">
                                        <input type="checkbox" id="fixed-right-sidebar" name="fixed-right-sidebar" checked>
                                        <span class="button-checkbox"></span>
                                    </label>
                                    <label for="fixed-right-sidebar">Sidebar direita fixa</label>
                                </div>
                            </li>
                        </ul>
                    </li>

                </ul>
                <!-- / top right nav -->
            </div>
            <!-- / collapse -->
        </div>
        <!-- / page-navbar -->