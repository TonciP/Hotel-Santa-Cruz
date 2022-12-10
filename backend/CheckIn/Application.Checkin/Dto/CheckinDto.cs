﻿using Domain.Estadia.Model.CreditCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class CheckinDto
    {
        public Guid CheckinId { get; set; }

        public Guid ReservaId { get; set; }

        public CreditCard CreditCard { get; set; }

        public Guid HabitacionId { get; set; }

        public Guid HuespedId { get; set; }
    }
}
