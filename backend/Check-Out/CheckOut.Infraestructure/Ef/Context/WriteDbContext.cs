using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.Ef.Context
{
    internal class WriteDbContext : DbContext
    {
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.ApplyConfiguration<Cliente>(new ClienteWriteConfig());
            modelBuilder.ApplyConfiguration<Factura>(new FacturaWriteConfig());
            modelBuilder.ApplyConfiguration<Pago>(new PagoWriteConfig());


        }
    }
}
