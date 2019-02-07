using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionCartas.Consultas
{
    public partial class ConsultaCartas : System.Web.UI.Page
    {
        Expression<Func<Cartas, bool>> filter = x => true;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BuscarLinkButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Cartas> rep = new RepositorioBase<Cartas>();
            Filtrar();
            CartasGridView.DataSource = rep.GetList(filter);
            CartasGridView.DataBind();
        }

        private void Filtrar()
        {
            int dato = 0;
            switch (FiltroDropDownList.SelectedIndex)
            {
                case 0://Todo
                    filter = x => true;
                    break;

                case 1://CartaID
                    dato = int.Parse(BuscarTextBox.Text);
                    filter = (x => x.CartaID == dato);
                    break;

                case 2://DestinatarioID
                    dato = int.Parse(BuscarTextBox.Text);
                    filter = (x => x.DestinatarioID == dato);
                    break;

                case 3://Fecha
                    filter = (x => x.Fecha.Equals(BuscarTextBox.Text));
                    break;

                case 4://Cuerpo
                    filter = (x => x.Cuerpo.Contains(BuscarTextBox.Text));
                    break;

                case 5://Cantidad
                    double monto = double.Parse(BuscarTextBox.Text);
                    filter = (x => x.Cantidad == monto);
                    break;
            }
        }

        protected void DepositoGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            RepositorioBase<Cartas> rep = new RepositorioBase<Cartas>();
            CartasGridView.DataSource = rep.GetList(filter);
            CartasGridView.PageIndex = e.NewPageIndex;
            CartasGridView.DataBind();
        }

    }
}