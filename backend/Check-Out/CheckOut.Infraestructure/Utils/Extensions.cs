using CheckOut.Infraestructure.Ef.Context;
using CheckOut.Infraestructure.Ef;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using CheckOut.Aplication.Utils;

namespace CheckOut.Infraestructure.Utils
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAapplication();

            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ReservaConnectionString"));
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ReservaConnectionString"));
            });
            //Scoped: se crea una instancia por cada request
            //Transient: se crea una instancia por cada uso
            //Singleton: se crea una instancia por cada aplicación
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IClienteRepository, ClienteRepository>();
            //services.AddScoped<IReservarRepository, ReservaRepository>();
            //services.AddScoped<IEstadiaRepository, EstadiaRepository>();

            return services;
        }
    }
}
