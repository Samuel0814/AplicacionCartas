using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioCartas : RepositorioBase<Cartas>
    {
        public override bool Eliminar(int id)
        {
            var carta = Buscar(id);
            Destinatario destinatario = carta.Destinatario;

            destinatario.CantidadCartas -= carta.Cantidad;

            _contexto.Entry(destinatario).State = EntityState.Modified;
            _contexto.SaveChanges();

            return base.Eliminar(id);
        }

        public override bool Guardar(Cartas entity)
        {
            var destinatario = _contexto.destinatarios.Find(entity.DestinatarioID);
            destinatario.CantidadCartas += entity.Cantidad;
            _contexto.Entry(destinatario).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();

            return base.Guardar(entity);
        }

        public override bool Modificar(Cartas entity)
        {
            var cartaAnterior = _contexto.Carta.Include(x => x.Destinatario)
                            .Where(z => z.CartaID == entity.CartaID)
                            .AsNoTracking()
                            .FirstOrDefault();

            Destinatario cuenta = cartaAnterior.Destinatario;
            cuenta.CantidadCartas -= cartaAnterior.Cantidad;

            cuenta.CantidadCartas += entity.Cantidad;
            _contexto.Entry(cuenta).State = EntityState.Modified;
            _contexto.SaveChanges();

            return base.Modificar(entity);
        }

        public RepositorioCartas() : base()
        {

        }

        public override Cartas Buscar(int id)
        {
            var d = _contexto.Carta.Include(x => x.Destinatario)
                    .Where(z => z.CartaID == id)
                    .FirstOrDefault();
            return d;
        }
    }
}
