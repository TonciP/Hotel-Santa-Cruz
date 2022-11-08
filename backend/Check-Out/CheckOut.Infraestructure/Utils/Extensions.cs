using CheckOut.Infraestructure.EF.Context;
using CheckOut.Infraestructure.EF;
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
using CheckOut.Domain.Factories.Factura;
using CheckOut.Infraestructure.EF.Repository;
using CheckOut.Domain.Repositories;


namespace CheckOut.Infraestructure.Utils
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddApplication();

            services.AddDbContext<ReadDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CheckOutConnectionString"));
            });
            services.AddDbContext<WriteDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CheckOutConnectionString"));
            });
            //Scoped: se crea una instancia por cada request
            //Transient: se crea una instancia por cada uso
            //Singleton: se crea una instancia por cada aplicación
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IFacturaRepository, FacturaRepository>();
            services.AddScoped<IPagoRepository, PagoRepository>();
            services.AddScoped<ICheckOutRepository, CheckOutRepository>();

            return services;
        }
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}
