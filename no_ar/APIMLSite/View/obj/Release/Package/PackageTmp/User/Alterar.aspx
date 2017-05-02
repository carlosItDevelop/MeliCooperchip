<%@ Page Title="" Language="C#" MasterPageFile="~/frontend.Master" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="SimpleMembershipLocalDatabase.User.Alterar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="frontendContent" runat="server">
    <h2>Alterar Senha</h2>
    
    
        <div role="form" class="row">
            <div class="col-xs-3">            
                <div class="form-group">
                    <asp:TextBox runat="server" ID="txtSenhaAtual" TextMode="Password" CssClass="form-control" placeholder="Senha atual" />
                </div>
                <div class="form-group">
                    <asp:TextBox runat="server" ID="txtNovaSenha" TextMode="Password" CssClass="form-control" placeholder="Nova senha" />
                </div>
                <p>
                    <asp:LinkButton Text="Alterar" runat="server" ID="btnAlterar" CssClass="btn btn-primary" OnClick="btnAlterar_Click"/>                                
                </p>
                <p>
                    <a href="Default.aspx">Voltar ao início</a>
                </p>
            </div>
        </div>
    

</asp:Content>
