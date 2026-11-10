using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP8_GRUPO_8
{
	public partial class ejercicio1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                ddlProvincia.DataSource = new NegocioProvincia().getTabla();
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();
                ddlProvincia.Items.Insert(0, new ListItem("--Seleccionar--", "0"));
            }
        }

        private void LimpiarCampos()
        {
            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
        }

        protected void btnAceptar_Click(object sender, EventArgs e) 
        {
           if (!Page.IsValid)
            {

                return;

            }

            Sucursal suc = new Sucursal();

            suc.setNombreSucursal(txtNombreSucursal.Text);
            suc.setDescripcionSucursal(txtDescripcion.Text);
            suc.setDireccionSucursal(txtDireccion.Text);
            suc.setIdProvinciaSucursal(int.Parse(ddlProvincia.SelectedValue));

            NegocioSucursal neg = new NegocioSucursal();

            if (neg.agregarSucursal(suc))
            {
                lblMensaje.Text = "La sucursal se ha agregado con éxito";
                LimpiarCampos();

            }

            else
            {

                lblMensaje.Text = "No se pudo agregar la sucursal";
            }
        }
    }
}