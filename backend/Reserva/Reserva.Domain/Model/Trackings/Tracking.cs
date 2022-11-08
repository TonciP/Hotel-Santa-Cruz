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
        //[Key]
        //public Guid Id { get; set; }
        public Guid Hash { get; private set; }

        public Tracking()
        {

        }
        public Tracking(Guid hash)
        {
            Id = Guid.NewGuid();
            Hash = hash;
        }
        //public Tracking() { }
    }
}
