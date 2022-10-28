using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Reserva.Domain.Factories.cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Aplication.Utils
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IClienteFactory, ClienteFactory>();

            return services;
        }
    }
}
