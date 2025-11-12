<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_16._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        
        <div style="height:200px; width:500px">
            <asp:Label ID="lbl_mensaje" runat="server" ForeColor="Red" Font-Size="35px"/>
        </div>

        <div style="height:200px; width:500px">
            <asp:Button ID="btn_mensaje" Text="Mostrar mensaje" ToolTip="Dar click para mostrar mensaje" runat="server" OnClick="btn_mensaje_Click"/>
        </div>

    </div>

</asp:Content>
