using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Estadia.Model.Habitacion
{
    public class Habitacion : AggregateRoot
    {
        public string CodigoHabitacion { get; set; }

        public string LimitePersona { get; set; }

        public Guid TipoHabitacion { get; set; }

        public double PrecioHabitacion { get; set; }

        public int NumeroHabitacion { get; set; }

        public string CaracteristicasHabitacion { get; set; }

        public string Disponibilidad { get; set; }

        public Habitacion(string codigoHabitacion, string limitePersona, Guid tipoHabitacion, double precioHabitacion, int numeroHabitacion, string caracteristicasHabitacion, string disponibilidad)
        {
            Id = Guid.NewGuid();
            CodigoHabitacion = codigoHabitacion;
            LimitePersona = limitePersona;
            TipoHabitacion = tipoHabitacion;
            PrecioHabitacion = precioHabitacion;
            NumeroHabitacion = numeroHabitacion;
            CaracteristicasHabitacion = caracteristicasHabitacion;
            Disponibilidad = disponibilidad;
        }

        public void EditHabitacion(string codigoHabitacion, string limitePersona, Guid tipoHabitacion, double precioHabitacion, int numeroHabitacion, string caracteristicasHabitacion, string disponibilidad)
        {
            CodigoHabitacion = codigoHabitacion;
            LimitePersona = limitePersona;
            TipoHabitacion = tipoHabitacion;
            PrecioHabitacion = precioHabitacion;
            NumeroHabitacion = numeroHabitacion;
            CaracteristicasHabitacion = caracteristicasHabitacion;
            Disponibilidad = disponibilidad;
        }
       
        public Habitacion(){ }
    }
}
