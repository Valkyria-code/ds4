<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_20_1.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Tabla de Multiplicar</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px;">
            <h2>Tabla de Multiplicar hasta el 25</h2>
            <br />
            
            <label>Ingrese un número:</label>
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Tabla" OnClick="btnGenerar_Click" />
            
            <br /><br />
            
            <asp:Literal ID="litResultado" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>