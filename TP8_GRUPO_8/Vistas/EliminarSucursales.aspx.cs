using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP8_GRUPO_8.Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                
            }
        }

        protected void txtIdSucursal_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;


            int id = int.Parse(txtIdSucursal.Text);

            NegocioSucursal negocio = new NegocioSucursal();

            bool eliminado = negocio.eliminarSucursal(id);

            if (eliminado)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con éxito";
            }
            else
            {
                lblMensaje.Text = "No existe una sucursal con ese ID";
            }
        }
    }
}