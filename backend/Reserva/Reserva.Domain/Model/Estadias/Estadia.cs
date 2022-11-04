using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Estadias
{
    public class Estadia : Entity
    {

        public DateTime FechaIngreso { get;  set; }
        public DateTime FechaSalida { get;  set; }

        public Estadia(DateTime fechaIngreso, DateTime fechaSalida)
        {
            Id = Guid.NewGuid();
            FechaIngreso = fechaIngreso;
            FechaSalida = fechaSalida;
        }

        public Estadia() { }
    }
}
