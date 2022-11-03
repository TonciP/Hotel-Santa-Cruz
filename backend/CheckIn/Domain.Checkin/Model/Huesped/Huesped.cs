using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Checkin.Model.Huesped
{
    public class Huesped : AggregateRoot<Guid>
    {
        //public Guid ClienteId { get; private set; }
        public DniValue? DNI { get; private set; }
        public Guid? HuespedId { get; set; }

        public Huesped(Guid huespedId,string dni)
        {
            Id = Guid.NewGuid();
            DNI = dni;
            HuespedId = huespedId;
        }

        
        // Only for Entity Framework
        public Huesped() { }

    }
}
