using CheckOut.Infraestructure.EF.Config.ReadConfig;
using CheckOut.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.EF.Context
{
    internal class ReadDbContext: DbContext
    {
        public virtual DbSet<FacturaReadModel> Facturas { get; set; }
        public virtual DbSet<PagoReadModel> Pagos { get; set; }
        public virtual DbSet<CheckOutReadModel> CheckOut { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<FacturaReadModel>(new FacturaReadConfig());
            modelBuilder.ApplyConfiguration<PagoReadModel>(new PagoReadConfig());
            modelBuilder.ApplyConfiguration<CheckOutReadModel>(new CheckOutrReadConfig());
            modelBuilder.ApplyConfiguration<DetalleFacturaReadModel>(new DetalleFacturaReadConfig());

        }
    }
}
