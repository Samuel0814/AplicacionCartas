using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionCartas.Registros
{
    public partial class RegistroCartas : System.Web.UI.Page
    {
        private RepositorioBase<Cartas> XD = new RepositorioCartas();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Destinatario> rb = new RepositorioBase<Destinatario>();
            DestinatarioDropDownList.DataSource = rb.GetList(x => true);
            DestinatarioDropDownList.DataValueField = "DestinatarioID";
            DestinatarioDropDownList.DataTextField = "Nombre";
            DestinatarioDropDownList.DataBind();
            DestinatarioDropDownList.Items.Insert(0, new ListItem("", ""));
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Cartas> rb = new RepositorioBase<Cartas>();
            Cartas cartas = rb.Buscar(int.Parse(TextBoxCartasID.Text));
            if (cartas != null)
                LlenarCampos(cartas);
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            TextBoxCartasID.Text = string.Empty;
            TextBoxFecha.Text = string.Empty;
            TextBoxCuerpo.Text = string.Empty;
            TextBoxCantidad.Text = string.Empty;
        }

        private Cartas LlenaClase()
        {
            int id;
            if (TextBoxCartasID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxCartasID.Text);

            return new Cartas(
                id,
                DateTime.Parse(TextBoxFecha.Text),
                int.Parse(DestinatarioDropDownList.SelectedValue),
                TextBoxCuerpo.Text,
                int.Parse(TextBoxCantidad.Text)
            );
        }


        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioCartas XD = new RepositorioCartas();
                int.TryParse(TextBoxCartasID.Text, out int id);
                if (id == 0)
                {
                    if (XD.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('Carta Guardada')", true);
                    Limpiar();
                }
                else
                {
                    XD.Modificar(LlenaClase());
                    Limpiar();
                }
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioCartas XD = new RepositorioCartas();
            Cartas cartas = XD.Buscar(int.Parse(TextBoxCartasID.Text));

            if (cartas != null)
            {
                XD.Eliminar(int.Parse(TextBoxCartasID.Text));
                Limpiar();
            }
        }

        private void LlenarCampos(Cartas cartas)
        {
            TextBoxFecha.Text = cartas.Fecha.ToString();
            DestinatarioDropDownList.SelectedValue = cartas.DestinatarioID.ToString();
            TextBoxCuerpo.Text = cartas.Cuerpo;
            TextBoxCantidad.Text = cartas.Cantidad.ToString();
        }

    }
}