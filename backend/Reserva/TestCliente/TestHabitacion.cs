<<<<<<< HEAD
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Habitaciones;

namespace TestCliente
{
    public class TestHabitacion
    {
        [Fact]
        public void HabitacionCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string codigoHabitacion = "asd";
            int limitePersona = 1;
            string tipoHabitacion = "asd";
            decimal precioHabitacion = decimal.MaxValue;
            int numeroHabitacion = 1;
            string caracteristicaHabitacion = "asd";
            string diponibilidad = "asd";

            Habitacion habitacion = new Habitacion(codigoHabitacion, limitePersona, tipoHabitacion, precioHabitacion, numeroHabitacion, caracteristicaHabitacion, diponibilidad);

            Assert.NotNull(habitacion.CodigoHabitacion);
            Assert.Equal(codigoHabitacion, habitacion.CodigoHabitacion);

            Assert.NotNull(habitacion.LimitePersona);
            Assert.Equal(limitePersona, (int)habitacion.LimitePersona);

            Assert.NotNull(habitacion.TipoHabitacion);
            Assert.Equal(tipoHabitacion, habitacion.TipoHabitacion);

            Assert.NotNull(habitacion.PrecioHabitacion);
            Assert.Equal(precioHabitacion, (decimal)habitacion.PrecioHabitacion);

            Assert.NotNull(habitacion.NumeroHabitacion);
            Assert.Equal(numeroHabitacion, habitacion.NumeroHabitacion);

            Assert.NotNull(habitacion.CaracteristicaHabitacion);
            Assert.Equal(caracteristicaHabitacion, habitacion.CaracteristicaHabitacion);

            Assert.NotNull(habitacion.Disponibilidad);
            Assert.Equal(diponibilidad, habitacion.Disponibilidad);



        }
        
    }
}
=======
﻿
>>>>>>> b9c02606c82056eece3e9bdcbe65124673e4e299
