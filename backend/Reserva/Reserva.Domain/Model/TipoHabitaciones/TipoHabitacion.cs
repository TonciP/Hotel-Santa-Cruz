using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.TipoHabitaciones
{
    public class TipoHabitacion : AggregateRoot
    {
        public string NombreHabitacion { get;  set; }
        public string Descripcion { get;  set; }
        public CantidadValue CantidadDisponible { get;  set; }
        //public PrecioValue TipoHabitacionId { get; private set; }
        public PrecioValue Costo { get;  set; }

        //public TipoHabitacion(string nombreHabitacion, string descripcion, CantidadValue cantidadDiponible, PrecioValue costo)
        //{
        //    Id = Guid.NewGuid();
        //    NombreHabitacion= nombreHabitacion;
        //    Descripcion= descripcion;
        //    CantidadDisponible = cantidadDiponible;
        //    Costo = costo;

        //}

        public TipoHabitacion(string nombreHabitacion, string descripcion, int cantidadDiponible, decimal costo)
        {
            Id = Guid.NewGuid();
            NombreHabitacion = nombreHabitacion;
            Descripcion = descripcion;
            CantidadDisponible = cantidadDiponible;
            Costo = costo;

        }

        public TipoHabitacion() { }
    }
}
