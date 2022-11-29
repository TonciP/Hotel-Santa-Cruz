using CheckOut.Domain.Model.checkouts;
using CheckOut.Domain.Model.Facturas;
using CheckOut.Domain.Model.Pagos;
using CheckOut.Infraestructure.EF.Config.WriteConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Facturar> Facturar { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<CheckOutr> CheckOutr { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFactura { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration<Cliente>(new ClienteWriteConfig());
            
            modelBuilder.ApplyConfiguration<Pago>(new PagoWriteConfig());
            modelBuilder.ApplyConfiguration<CheckOutr>(new CheckOutrWriteConfig());
            modelBuilder.ApplyConfiguration<Facturar>(new FacturaWriteConfig());
            modelBuilder.ApplyConfiguration<DetalleFactura>(new DetalleFacturaWriteConfig());


        }
    }
}
