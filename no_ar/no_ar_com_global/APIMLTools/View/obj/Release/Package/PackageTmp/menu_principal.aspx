﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_principal.aspx.cs" Inherits="View.MenuVertical" %>


<%--        <!-- #wrapper -->
        <div id="wrapper">--%>

            <!-- .page-sidebar -->
            <aside id="sidebar" class="page-sidebar hidden-md hidden-sm hidden-xs">
                <!-- Start .sidebar-inner -->
                <div class="sidebar-inner">
                    <!-- Start .sidebar-scrollarea -->
                    <div class="sidebar-scrollarea">
                        <!--  .sidebar-panel -->
                        <div class="sidebar-panel">
                            <h5 class="sidebar-panel-title">Perfil</h5>
                        </div>
                        <!-- / .sidebar-panel -->
                        <div class="user-info clearfix">
                            <img src="/img/avatars/128.jpg" alt="avatar">
                            <span class="name">Carlos Alberto</span>
                            <div class="btn-group">
                                <button type="button" class="btn btn-default btn-xs"><i class="l-basic-gear"></i>
                                </button>
                                <button type="button" class="btn btn-default btn-xs dropdown-toggle" data-toggle="dropdown">settings <span class="caret"></span>
                                </button>
                                <ul class="dropdown-menu right" role="menu">
                                    <li><a href="profile.aspx"><i class="fa fa-edit"></i>Editar Perfil</a></li>
                                </ul>
                            </div>
                        </div>
                        
                        <!--  .sidebar-panel -->
                        <div class="sidebar-panel">
                            <h5 class="sidebar-panel-title">Navegação</h5>
                        </div>
                        <!-- / .sidebar-panel -->

                        <!-- .side-nav -->
                        <div class="side-nav">
                            <ul class="nav">
                                <li><a href="/default.aspx"><i class="l-basic-laptop"></i><span class="txt">Dashboard</span></a></li>
                                <li><a href="/recursos.aspx"><i class="l-software-layers2"></i><span class="txt">API Recursos</span></a></li>
                                
                                <li><a href="#"><i class=" l-basic-webpage-img-txt "></i><span class="txt">Mercadolivre</span></a>
                                    <ul class="sub">
                                        <li><a href="frmMeuMercadolivre.aspx"><span class="txt">Meu Mercadolivre</span></a></li>
                                        <li><a href="#"><span class="txt">Resumo</span></a></li>
                                        <li><a href="#"><span class="txt">Faturas</span></a></li>
                                        <li><a href="#"><span class="txt">Reputação</span></a></li>

                                        <li><a href="frmConfigMercadolivre.aspx"><span class="txt">Configurações</span></a></li>
                                        <li><a href="#"><span class="txt">BlackList</span></a></li>
                                        <li><a href="#"><span class="txt">Interessados</span></a></li>

                                        <li><a href="#"><span class="txt">Compras</span></a>
                                            <ul class="sub">
                                                <li><a href="#"><span>Favoritos</span></a></li>
                                                <li><a href="#"><span>Perguntas</span></a></li>
                                                <li><a href="#"><span>Compras</span></a></li>
                                            </ul>
                                        </li>
                                        <li><a href="#"><span class="txt">Vendas</span></a>
                                            <ul class="sub">
                                                <li><a href="#"><span>Anúncios</span></a></li>
                                                <li><a href="#"><span>Perguntas</span></a></li>
                                                <li><a href="#"><span>Pedidos</span></a>
                                         <%--       <ul class="sub">
                                                        <li><a href="pedidos.aspx"><span>Abertos</span></a></li>
                                                        <li><a href="#"><span class="txt">Pendentes</span></a></li>
                                                        <li><a href="#"><span class="txt">Aqrquivados</span></a></li>
                                                        <li><a href="#"><span class="txt">Completos</span></a></li>
                                                        <li><a href="#"><span class="txt">Cancelados</span></a></li>
                                                        <li><a href="#"><span class="txt">Em mediação</span></a></li>
                                                    </ul>    --%>
                                                </li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>

                                <li><a href="/frmLerXML.aspx"><i class="l-software-reflect-vertical"></i><span class="txt">CrossDocking</span></a></li>
                                
                                <li><a href="#" target="_blank"><i class="l-software-remove-vectorpoint"></i><span class="txt">Importar XMLs</span></a>
                                    <ul class="sub">
                                        <li><a href="/frmPostParaHayamax.aspx" target="_blank"><span class="txt">Hayamax</span></a></li>
                                        <li><a href="/frmPostParaAldo.aspx" target="_blank"><span class="txt">Aldo</span></a></li>
                                        <li><a href="#"><span class="txt">Evolusom</span></a></li>
                                        <li><a href="#"><span class="txt">Oderço</span></a></li>
                                    </ul>
                                </li>

                                <li><a href="#"><i class="l-software-layout-header"></i><span class="txt">Documentação</span></a></li>

                        <%--    <li><a href="#"><i class="l-basic-settings"></i><span class="txt">Itens Com</span></a>
                                    <ul class="sub">
                                        <li><a href="#"><span class="txt">Itens Comerciais</span></a></li>
                                        <li><a href="#"><span class="txt">Estoques</span></a></li>
                                        <li><a href="#"><span class="txt">Publicidade</span></a></li>
                                    </ul>
                                </li>   --%>

                            </ul>
                        </div>
                        <!-- / side-nav -->

                    </div>
                    <!-- End .sidebar-scrollarea -->
                </div>
                <!-- End .sidebar-inner -->
            </aside>
 <%--       </div>--%>

        