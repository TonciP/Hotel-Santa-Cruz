﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.ReadModel
{
    internal class EstadiaReadModel
    {
        //[IgnoreDataMember]
        //public DateTime current_time = DateTime.Today.ToString();

        [Key]
        [Column("estadiaId")]
        public Guid Id { get; set; }

        [Required]
        [Column(name: "fechaEntrada", TypeName = "Date")]
        public DateTime FechaEntrada { get; set; }

        [Required]
        [Column(name: "fechaSalida" , TypeName = "Date")]
        public DateTime FechaSalida { get; set; }

        public EstadiaReadModel()
        {

        }


    }
}
