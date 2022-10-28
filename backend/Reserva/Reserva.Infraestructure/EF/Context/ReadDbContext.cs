﻿using Microsoft.EntityFrameworkCore;
using Reserva.Infraestructure.EF.Config.ReadConfig;
using Reserva.Infraestructure.EF.ReadModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Context
{
    internal class ReadDbContext : DbContext
    {
        public virtual DbSet<ClienteReadModel> Clientes { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<ClienteReadModel>(new ClienteReadConfig());

        }
    }
}