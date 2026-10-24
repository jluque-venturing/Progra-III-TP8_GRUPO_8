<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursales.aspx.cs" Inherits="TP8_GRUPO_8.Vistas.EliminarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Eliminar Sucursales</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            width: 162px;
        }

        .auto-style3 {
            width: 213px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td style="text-align: center; vertical-align: middle">

                        <asp:HyperLink ID="hlAgregar" runat="server"
                            NavigateUrl="~/Vistas/ejercicio1.aspx">
                Agregar Sucursal
                        </asp:HyperLink>

                    </td>
                    <td style="text-align: center; vertical-align: middle">
                        <asp:HyperLink ID="hlListado" runat="server"
                            NavigateUrl="~/Vistas/ListadoSucursales.aspx">
                Listado de Sucursales
                        </asp:HyperLink>
                    </td>
                    <td style="text-align: center; vertical-align: middle">
                        <asp:HyperLink ID="hlEliminar" runat="server"
                            NavigateUrl="~/Vistas/EliminarSucursales.aspx">
                Eliminar Sucursal
                        </asp:HyperLink>

                    </td>
                </tr>
            </table>
            <h2>Eliminar Sucursales</h2>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: center">
                        <asp:Label ID="Label1" runat="server" Text="Ingresar ID sucursal"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtIdSucursal" runat="server" OnTextChanged="txtIdSucursal_TextChanged" Width="189px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Width="103px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            &nbsp;
            <br />
            <br />
        </div>
    </form>
</body>
</html>
