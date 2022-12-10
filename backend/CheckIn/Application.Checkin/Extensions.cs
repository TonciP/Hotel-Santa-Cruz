using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Domain.Estadia.Factories;
using Reserva.Domain.Factories;

namespace Application.Estadia
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<ICheckInFactory, CheckInFactory>();
            services.AddScoped<ICreditCardFactory, CreditCardFactory>();
            services.AddScoped<IHabitacionFactory, HabitacionFactory>();
            services.AddScoped<IHuespedFactory, HuespedFactory>();

            return services;
        }
    }
}

