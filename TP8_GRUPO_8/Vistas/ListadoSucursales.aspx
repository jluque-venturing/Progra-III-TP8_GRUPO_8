<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="TP8_GRUPO_8.Vistas.ListadoSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado de Sucursales</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 33px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            width: 228px;
            height: 21px;
        }
        .auto-style6 {
            width: 239px;
            height: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            &nbsp;&nbsp;&nbsp;&nbsp;

            &nbsp;&nbsp;&nbsp;&nbsp;

            <table class="auto-style1">
                <tr>
                    <td aria-grabbed="false" aria-orientation="horizontal" class="auto-style5">

            <asp:HyperLink ID="hlAgregar" runat="server"
                NavigateUrl="~/Vistas/ejercicio1.aspx">
                Agregar Sucursal
            </asp:HyperLink>

                    </td>
                    <td aria-grabbed="false" aria-orientation="horizontal" class="auto-style6">

            <asp:HyperLink ID="hlListado" runat="server"
                NavigateUrl="~/Vistas/ListadoSucursales.aspx">
                Listado de Sucursales
            </asp:HyperLink>

                    </td>
                    <td aria-grabbed="false" aria-orientation="horizontal" class="auto-style4">

            <asp:HyperLink ID="hlEliminar" runat="server"
                NavigateUrl="~/Vistas/EliminarSucursales.aspx" Font-Strikeout="False">
                Eliminar Sucursal
            </asp:HyperLink>

                    </td>
                </tr>
            </table>

            <h2>Listado de Sucursales</h2>

            <br /><br />

        </div>
    </form>
</body>
</html>