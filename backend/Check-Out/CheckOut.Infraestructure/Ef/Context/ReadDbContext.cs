using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.Ef.Context
{
    internal class ReadDbContext: DbContext
    {
        public virtual DbSet<FacturaReadModel> Facturas { get; set; }
        public virtual DbSet<PagoReadModel> Pagos { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration<FacturaReadModel>(new FacturaReadConfig());

        }
    }
}
