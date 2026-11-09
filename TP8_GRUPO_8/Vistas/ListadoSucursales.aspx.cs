using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TP8_GRUPO_8.Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvSucursales.DataSource = neg.getTabla();
                gvSucursales.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                limpiarCampos();
                return;
            }
            NegocioSucursal negocio_Sucursal = new NegocioSucursal();

            gvSucursales.DataSource = negocio_Sucursal.getTablaFiltrada(int.Parse(txtIdSucursal.Text));

            gvSucursales.DataBind();

            limpiarCampos();
                
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            gvSucursales.DataSource = neg.getTabla();
            gvSucursales.DataBind();

            limpiarCampos();
        }

        private void limpiarCampos()
        {

            txtIdSucursal.Text = string.Empty;

        }
    }
}