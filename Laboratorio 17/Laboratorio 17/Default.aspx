<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <asp:GridView id="MyGridView" 
            DataSourceID="MyDataSource1" 
            AllowSorting="true" 
            AllowPaging="true" 
            DataKeyNames="ProductID" 
            AutoGenerateEditButton="true" 
            runat="server" />

        <asp:SqlDataSource ID="MyDataSource1" 
            runat="server" 
            ConnectionString="data source=.;initial catalog=northwind;persist security info=true;Integrated Security=SSPI;"
            ProviderName="System.Data.SqlClient"
            SelectCommand="select ProductId, ProductName, UnitPrice from Products"
            UpdateCommand="update Products set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice where [ProductId]=@ProductId">
        </asp:SqlDataSource>
    </div>

</asp:Content>
