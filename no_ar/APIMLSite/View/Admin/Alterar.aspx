<%@ Page Title="" Language="C#" MasterPageFile="~/frontend.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="SimpleMembershipLocalDatabase.Admin.Alterar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="frontendContent" runat="server">
    <h2>Alterar Usuário</h2>
    <div role="form" class="row">
        <div class="col-xs-3">
            <div class="form-group">
                <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" placeholder="Nome completo" />
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="txtTelefone" CssClass="form-control" placeholder="Telefone principal" />
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="txtDataNascimento" CssClass="form-control" placeholder="Data de nascimento" />
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="txtUsuario" TextMode="Email" CssClass="form-control" Enabled="false" />
            </div>            
            <div class="checkbox">
                <label>
                    <asp:CheckBox runat="server" ID="chkAdmin" />
                    Administrador
                </label>
            </div>
            <div class="checkbox">
                <label>
                    <asp:CheckBox runat="server" ID="chkUser" />
                    Usuário
                </label>
            </div>
            <p>
                <asp:LinkButton Text="Alterar" runat="server" ID="btnAlterar" CssClass="btn btn-primary"
                    OnClick="btnAlterar_Click" />
            </p>
            <p>
                <a href="/Default.aspx">Voltar ao início</a>
            </p>
        </div>
    </div>
</asp:Content>
