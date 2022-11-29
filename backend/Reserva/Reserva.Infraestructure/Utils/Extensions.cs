﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reserva.Aplication.Utils;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Repositories;
using Reserva.Infraestructure.EF;
using Reserva.Infraestructure.EF.Context;
using Reserva.Infraestructure.EF.Repository;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reserva.Infraestructure.utils
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddApplication();

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
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<ITrackingRepository, TrackingRepository>();
            //services.AddScoped<IHabitacionRepository, HabitacionRepository>();
            services.AddScoped<ITipoHabitacionRepository, TipoHabitacionRepository>();
            services.AddScoped<IReservarRepository, ReservaRepository>();
            //services.AddScoped<IEstadiaRepository, EstadiaRepository>();

            return services;
        }
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source?.IndexOf(toCheck, comp) >= 0;
        }
    }
}
