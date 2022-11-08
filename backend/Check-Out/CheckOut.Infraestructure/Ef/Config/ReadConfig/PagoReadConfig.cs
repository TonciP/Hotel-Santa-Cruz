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
    internal class PagoReadConfig : IEntityTypeConfiguration<PagoReadModel>
    {
        public void Configure(EntityTypeBuilder<PagoReadModel> builder)
        {
            throw new NotImplementedException();
        }
    }
}
