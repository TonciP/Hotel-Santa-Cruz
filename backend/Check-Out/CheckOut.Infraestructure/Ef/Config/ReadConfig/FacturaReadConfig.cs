using CheckOut.Infraestructure.Ef.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Infraestructure.Ef.Config.ReadConfig
{
    internal class FacturaReadConfig : IEntityTypeConfiguration<FacturaReadModel>
    {
        public void Configure(EntityTypeBuilder<FacturaReadModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
