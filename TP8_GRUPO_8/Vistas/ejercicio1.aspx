<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP8_GRUPO_8.ejercicio1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar Sucursal</title>
    <style type="text/css">
        .auto-style1 {
            width: 284px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 1338px">
            <tr>
                <td style="text-align: center; vertical-align: middle">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Vistas/ejercicio1.aspx">Agregar Sucursal</asp:HyperLink>
                </td>
                <td style="text-align: center; vertical-align: middle">
                    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Vistas/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                </td>
                <td style="text-align: center; vertical-align: middle">
                    <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Vistas/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                </td>
            </tr>
        </table>

        <h1>GRUPO N°</h1>
        <h2>Agregar Sucursal</h2>

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblNombreSucursal" runat="server" Text="Nombre Sucursal:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombreSucursal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDescripcion" runat="server" Text="Descripción:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblProvincia" runat="server" Text="Provincia:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlProvincia" runat="server">
                        <asp:ListItem Text="--Seleccionar--" Value=""></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDireccion" runat="server" Text="Dirección:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>