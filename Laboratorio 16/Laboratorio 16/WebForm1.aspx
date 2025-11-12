<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .cal
        {
            position: absolute;
            top: 50px;
            left: 150px;
            right: 400px;
            height: 600px;
            bottom: 100px;
            background-color: dodgerblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cal">
            <asp:Label ID="lbl" Text=" CALCULADORA BÁSICA" runat="server" Style="margin-left: 50px" Font-Bold="true" Font-Italic="false" ForeColor="White" Font-Size="25px"></asp:Label>
            <br />
            <asp:TextBox ID="txt" runat="server" Style="margin-left: 50px; margin-top: 24px;" Width="335px" Height="41px"></asp:TextBox>
            <asp:Button ID="btn_1" Text="1" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_1_Click" />
            <asp:Button ID="btn_2" Text="2" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_2_Click" />
            <asp:Button ID="btn_3" Text="3" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_3_Click" />
            <asp:Button ID="btn_suma" Text="+" runat="server" Height="37px" Width="57px" Style="margin-left: 0px; margin-top: 0px;" OnClick="btn_suma_Click" />
            <asp:Button ID="btn_4" Text="4" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_4_Click" />
            <asp:Button ID="btn_5" Text="5" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_5_Click" />
            <asp:Button ID="btn_6" Text="6" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_6_Click" />
            <asp:Button ID="btn_resta" Text="-" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_resta_Click" />
            <asp:Button ID="btn_7" Text="7" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_7_Click" />
            <asp:Button ID="btn_8" Text="8" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_8_Click" />
            <asp:Button ID="btn_9" Text="9" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_9_Click" />
            <asp:Button ID="btn_multiplicacion" Text="*" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_multiplicacion_Click" />
            <asp:Button ID="btn_0" Text="0" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_0_Click" />
            <asp:Button ID="btn_clear" Text="CLR" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_clear_Click" />
            <asp:Button ID="btn_igual" Text="=" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_igual_Click" />
            <asp:Button ID="btn_division" Text="/" runat="server" Height="37px" Width="57px" Style="margin-left: 0px" OnClick="btn_division_Click" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
