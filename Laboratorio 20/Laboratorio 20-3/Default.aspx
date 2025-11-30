<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_20_3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD Productos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 50px;">
            <h2>Gestión de Productos</h2>
            <br />

            <asp:Label ID="lblMensaje" runat="server" ForeColor="Green"></asp:Label>
            <br /><br />

            <table>
                <tr>
                    <td>ID:</td>
                    <td><asp:TextBox ID="txtId" runat="server" Enabled="false"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Nombre:</td>
                    <td><asp:TextBox ID="txtNombre" runat="server" Enabled="false"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Precio:</td>
                    <td><asp:TextBox ID="txtPrecio" runat="server" Enabled="false"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Stock:</td>
                    <td><asp:TextBox ID="txtStock" runat="server" Enabled="false"></asp:TextBox></td>
                </tr>
            </table>

            <br />

            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" />
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="false" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" />

            <br /><br />
            <h3>Lista de Productos</h3>

            <asp:GridView ID="gvProductos" runat="server" AutoGenerateColumns="false" 
                OnRowCommand="gvProductos_RowCommand" CellPadding="5" GridLines="Both">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" />
                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="precio" HeaderText="Precio" DataFormatString="{0:C2}" />
                    <asp:BoundField DataField="stock" HeaderText="Stock" />
                    <asp:TemplateField HeaderText="Acciones">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Editar" 
                                CommandName="Editar" 
                                CommandArgument='<%# Eval("id") %>' />
                            <asp:Button runat="server" Text="Eliminar" 
                                CommandName="Eliminar" 
                                CommandArgument='<%# Eval("id") %>'
                                OnClientClick="return confirm('¿Eliminar este producto?');" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>