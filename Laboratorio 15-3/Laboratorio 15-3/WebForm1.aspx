<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_15_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Suma de Nùmeros<p>
            Nùmero 1:
            <asp:TextBox ID="txt_uno" runat="server" Width="120px"></asp:TextBox>
        </p>
        <p>
            Nùmero 2:
            <asp:TextBox ID="txt_dos" runat="server" Width="120px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_igual" runat="server" OnClick="btn_igual_Click" Text="Igual a" Width="196px" />
        </p>
        <p>
            <asp:TextBox ID="txt_respuesta" runat="server"></asp:TextBox>
        </p>
    </form>
</body>
</html>
