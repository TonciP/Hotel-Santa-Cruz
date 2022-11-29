using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Huesped
{
    public class Huesped : AggregateRoot<Guid>
    {
        //public Guid ClienteId { get; private set; }
        public DniValue? DNI { get; private set; }

        public Huesped(string dni)
        {
            Id = Guid.NewGuid();
            DNI = dni;
        }
        public void EditHuesped(string dni)
        {
            DNI = dni.Trim();
        }

        
        // Only for Entity Framework
        public Huesped() { }

    }
}
