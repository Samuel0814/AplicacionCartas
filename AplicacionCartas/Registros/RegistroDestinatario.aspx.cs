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
    public partial class RegistroDestinatario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Destinatario> rb = new RepositorioBase<Destinatario>();
            Destinatario c = rb.Buscar(int.Parse(TextBoxDestinatarioID.Text));
            if (c != null)
            {
                TextBoxFecha.Text = c.Fecha.ToString();
                TextBoxNombre.Text = c.Nombre;
                TextBoxCantidadCartas.Text = c.CantidadCartas.ToString();
            }
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            TextBoxDestinatarioID.Text = string.Empty;
            TextBoxFecha.Text = string.Empty;
            TextBoxNombre.Text = string.Empty;
            TextBoxCantidadCartas.Text = string.Empty;
        }

        private Destinatario LlenaClase()
        {
            int id;
            if (TextBoxDestinatarioID.Text == String.Empty)
                id = 0;
            else
                id = int.Parse(TextBoxDestinatarioID.Text);
            return new Destinatario(
                id,
                DateTime.Parse(TextBoxFecha.Text),
                TextBoxNombre.Text
                );
        }

        protected void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                RepositorioBase<Destinatario> rb = new RepositorioBase<Destinatario>();

                int.TryParse(TextBoxDestinatarioID.Text, out int id);

                if (id == 0)
                {
                    if (rb.Guardar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('Destinatario Registrado')", true);
                    Limpiar();
                }
                else
                {
                    if (rb.Modificar(LlenaClase()))
                        ScriptManager.RegisterStartupScript(Page, typeof(Page), "Popup", "alert('Destinatario Modificada')", true);
                    Limpiar();
                }
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            RepositorioBase<Destinatario> rb = new RepositorioBase<Destinatario>();
            Destinatario c = rb.Buscar(int.Parse(TextBoxDestinatarioID.Text));

            if (c != null)
            {
                rb.Eliminar(int.Parse(TextBoxDestinatarioID.Text));
                Limpiar();
            }
        }
    }
}