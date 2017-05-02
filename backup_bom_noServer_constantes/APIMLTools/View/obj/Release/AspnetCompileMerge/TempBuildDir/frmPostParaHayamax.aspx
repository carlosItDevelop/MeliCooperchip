<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPostParaHayamax.aspx.cs" Inherits="view.frmPostParaHayamax" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>APIML | Tools - Management</title>
</head>
<body>
    <form id="fromAldoXML" runat="server">
    <div style="margin-left: 45px; margin-top: 15px; padding: 25px;">

        <h1>APIML | Tools - Management</h1>
        <h3>Importação de XML da Hayamax&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnProcessar" runat="server" OnClick="btnProcessar_Click" Text=".: Processar :." />
        </h3>

        <p><asp:Label ID="lblStatus" runat="server" Text=""></asp:Label></p>

        <br />
        <br />
        <asp:TextBox ID="txtXML" runat="server" BackColor="#FFFFCC" BorderStyle="Solid" Height="311px" TextMode="MultiLine" Width="1067px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblWait" runat="server" Text="Aguarde o término da requisição..."></asp:Label>
    </div>
    </form>
</body>
</html>
