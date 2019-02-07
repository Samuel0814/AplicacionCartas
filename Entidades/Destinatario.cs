using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Destinatario
    {
        [Key]
        public int DestinatarioID { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public int CantidadCartas { get; set; }

        public Destinatario(int destinatarioID, DateTime fecha, string nombre)
        {
            DestinatarioID = destinatarioID;
            Fecha = fecha;
            Nombre = nombre;
        }

        public Destinatario()
        {
            DestinatarioID = 0;
            Fecha = DateTime.Now;
            Nombre = String.Empty;
            CantidadCartas = 0;
        }
    }
}
