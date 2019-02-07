using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartas
    {
        [Key]
        public int CartaID { get; set; }
        public DateTime Fecha { get; set; }
        public int DestinatarioID { get; set; }
        public string Cuerpo { get; set; }
        public int Cantidad { get; set; }
        public virtual Destinatario Destinatario { get; set; }

        public Cartas(int cartaID, DateTime fecha, int destinatarioID, string cuerpo, int cantidad)
        {
            CartaID = CartaID;
            Fecha = fecha;
            DestinatarioID = destinatarioID;
            cuerpo = Cuerpo;
            cantidad = Cantidad;
        }

        public Cartas()
        {
            CartaID = 0;
            Fecha = DateTime.Now;
            DestinatarioID = 0;
            Cuerpo = String.Empty;
            Cantidad = 0;
        }
    }
}
