using Reserva.Domain.Model.Clientes;
using Reserva.Domain.Model.Estadias;
using Reserva.Domain.Model.Reservas;
using Reserva.Domain.Model.Trackings;

namespace TestCliente
{
    public class TestCliente
    {
        [Fact]
        public void ReservasCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            Tracking tracking = new Tracking();
            Guid habitacionid= Guid.NewGuid();
            Estadia estadia = new Estadia();
            Cliente cliente = new Cliente();

            Reservar reservar = new Reservar(tracking, habitacionid, estadia, cliente);

            Assert.NotNull(reservar._tracking);
            Assert.Equal(tracking, reservar._tracking);

            //Assert.NotNull(reservar.HabitacionId);
            Assert.Equal(habitacionid, reservar.HabitacionId);

            Assert.NotNull(reservar._estadia);
            Assert.Equal(estadia, reservar._estadia);

            Assert.NotNull(reservar._cliente);
            Assert.Equal(cliente, reservar._cliente);

            


        }
 
    }
}