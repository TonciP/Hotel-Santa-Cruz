﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.ReadModel
{
    internal class CreditCardReadModel
    {
        [Key]
        public Guid Id { get; set; }
        public string? TipoTarjeta { get; set; }

        public string? NumeroTarjeta { get; set; }
    }
}
