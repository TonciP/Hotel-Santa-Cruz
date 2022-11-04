using Microsoft.EntityFrameworkCore;
using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Reservas;
using Reserva.Infraestructure.EF.Config.ReadConfig;
using Reserva.Infraestructure.EF.Config.WriteConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Reservar> Reservar { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration<Cliente>(new ClienteWriteConfig());
            modelBuilder.ApplyConfiguration<Reservar>(new ReservaWriteConfig());


        }
    }
}
