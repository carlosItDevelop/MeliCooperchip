<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testeViewState.aspx.cs" Inherits="View.TesteViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="testeViewState.aspx" method="GET">
    <div>
        <asp:TextBox ID="txtTeste" runat="server" ViewStateMode="Disabled"></asp:TextBox>   -  <asp:Button ID="submit" runat="server" Text="enviar" />
    </div>
    </form>
</body>
</html>
