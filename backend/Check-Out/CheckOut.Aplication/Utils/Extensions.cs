using CheckOut.Domain.Factories.checkout;
using CheckOut.Domain.Factories.checkouts;
using CheckOut.Domain.Factories.factura;
using CheckOut.Domain.Factories.Factura;
using CheckOut.Domain.Factories.pago;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CheckOut.Aplication.Utils
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<ICheckOutFactory, CheckOutFactory>();
            services.AddScoped<IFacturaFactory, FacturaFactory>();
            services.AddScoped<IPagoFactory, PagoFactory>();
            // aplicar los factory
            return services;

        }
    }
}
