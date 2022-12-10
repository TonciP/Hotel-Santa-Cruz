using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Huespedes
{
    public class Huesped : Entity
    {
        //public Guid ClienteId { get; private set; }
        public string? DNI { get; private set; }

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
