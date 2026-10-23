<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ejercicio1.aspx.cs" Inherits="TP8_GRUPO_8.ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
            <table class="auto-style1">
                <tr>
                    <td style="vertical-align: middle; text-align: center">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Vistas/ejercicio1.aspx">Agregar Sucursal</asp:HyperLink>
                    </td>
                    <td style="vertical-align: middle; text-align: center">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Vistas/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
                    </td>
                    <td style="vertical-align: middle; text-align: center">
                        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Vistas/EliminarSucursales.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                </tr>
            </table>
            <h1>GRUPO N°</h1>
            <h2>Agregar Sucursal</h2>
        </div>
    </form>
</body>
</html>
