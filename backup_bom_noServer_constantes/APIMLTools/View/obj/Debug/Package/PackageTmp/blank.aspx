<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="blank.aspx.cs" Inherits="View.Blank" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentContainer" runat="server">

        <div id="page-header" class="clearfix">
            <div class="page-header">
                <h2>Personalize aqui</h2>
                <span class="txt">E aqui ponha o sub-title</span>
            </div>


            <% Server.Execute("boxes-cas.aspx"); %>


        </div>


        <!-- Start .row -->
        <div class="row">
            <div class="col-lg-12">
                <!-- col-lg-12 start here -->
                <div class="panel panel-default toggle panelMove panelClose panelRefresh">
                    <!-- Start .panel -->
                    <div class="panel-heading">
                        <h4 class="panel-title"><i class="fa fa-list-alt"></i> APIML | Tools - Management</h4>
                    </div>
                    <div class="panel-body pt0 pb0">

                    <!-- AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->



                    <!-- FIM - AQUI DEVEM ENTRAR AS PERSONALIZAÇÕES /-->
                  </div>
                </div>
            </div>
        </div>
        <!-- End .row -->
 

</asp:Content>
