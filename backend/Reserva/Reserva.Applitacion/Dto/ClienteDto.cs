﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.Dto
{
    public class ClienteDto
    {
        public Guid? clienteId { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

    }
}
