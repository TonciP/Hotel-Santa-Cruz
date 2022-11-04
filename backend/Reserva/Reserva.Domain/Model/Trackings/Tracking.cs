using Microsoft.EntityFrameworkCore;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Domain.Model.Trackings
{
    public class Tracking: Entity
    {
        //public Guid TrackingId { get; set; }
        [Key]
        public Guid Id { get; set; }
        public string Hash { get; private set; }

        public Tracking()
        {
            Id = Guid.NewGuid();
            Hash = Id.ToString();
        }
        //public Tracking() { }
    }
}
