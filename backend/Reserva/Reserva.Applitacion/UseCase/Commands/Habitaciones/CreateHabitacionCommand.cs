using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.UseCase.Commands.Habitaciones
{
    public class CreateHabitacionCommand : IRequest<Guid>
    {
        public string CodigoHabitacion { get; set; }
        public int LimitePersona { get; set; }
        public string TipoHabitacion { get; set; }
        public decimal PrecioHabitacion { get; set; }
        public int NumeroHabitacion { get; set; }
        public string CaracteristicaHabitacion { get; set; }
        public string Disponibilidad { get; set; }
    }
}
