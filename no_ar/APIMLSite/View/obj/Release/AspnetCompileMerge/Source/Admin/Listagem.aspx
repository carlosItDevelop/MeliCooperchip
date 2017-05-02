<%@ Page Title="" Language="C#" MasterPageFile="~/frontend.Master" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="SimpleMembershipLocalDatabase.Admin.Listagem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        table a:hover {
            text-decoration: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="frontendContent" runat="server">


<div class="container">         
        <div class="col-md-12">
           <div class="row">
               <div class="panel-heading">
                    <h4>Listagem de Usuários</h4>           
               </div>
    
                <asp:GridView runat="server" ID="gvUsuarios" CssClass="table table-bordered table-condensed table-hover table-striped"
                    SelectMethod="gvUsuarios_GetData" AutoGenerateColumns="false" OnRowCommand="gvUsuarios_RowCommand" 
                    ItemType="SimpleMembershipLocalDatabase.Usuario">
                    <Columns>
                        <asp:BoundField DataField="Nome" HeaderText="Nome completo"/>
                        <asp:BoundField DataField="Email" HeaderText="Usuário/e-mail"/>
                        <asp:BoundField DataField="Telefone" HeaderText="Telefone principal"/>
                        <asp:BoundField DataField="DataNascimento" HeaderText="Data Nascimento"/>
                        <asp:TemplateField HeaderText="Opções" ItemStyle-CssClass="text-center" HeaderStyle-CssClass="text-center">
                            <ItemTemplate>
                                <a href="<%#"Alterar.aspx?IdUsuario=" + Item.IdUsuario %>"><i class="icon-pencil"></i></a>                    
                                <asp:LinkButton runat="server" OnClientClick="return confirm('Deseja realmente excluir?');"
                                    CommandName="excluir" CommandArgument="<%# Item.Email %>">
                                    <i class="icon-remove"></i>
                                </asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

                <hr/>
        
		            <div class="mb-xs text-center">
			            <a href="Cadastrar.aspx" class="btn btn-facebook mb-md ml-xs mr-xs">Cadastrar outro usuário <i class="fa fa-user"></i></a>
			            <a href="/Default.aspx" class="btn btn-twitter mb-md ml-xs mr-xs">Voltar para Homepage <i class="fa fa-home"></i></a>
		            </div>
            
            </div>            
                    
        </div>
</div>
    
</asp:Content>
