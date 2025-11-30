<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Labratorio_20_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matriz Diagonal Inversa</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px;">
            <h2>Matriz N x N con Diagonal Inversa</h2>
            <p>La diagonal inversa tendrá 1's, el resto números consecutivos</p>
            <br />
            
            <label>Ingrese la dimensión N:</label>
            <asp:TextBox ID="txtDimension" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" />
            
            <br /><br />
            
            <asp:Literal ID="litResultado" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>