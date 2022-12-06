﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class CheckoutDto
    {
        public Guid Id { get; set; }

        public Guid ClienteId { get; set; }

        public Guid CreditCardId { get; set; }

        public Guid CheckInId { get; set; }

        public Guid FacturaId { get; set; }

        public Guid PagoId { get; set; }
    }
}
