using Reserva.Domain.Model.Estadias;

namespace TestCliente
{
    public class TestEstadia
    {
        [Fact]
        public void EstadiaCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            DateTime FechaIngreso = DateTime.Now;
            DateTime FechaSalida = DateTime.Now;

            Estadia estadia = new Estadia(FechaIngreso, FechaSalida);

            Assert.NotNull(estadia.FechaIngreso);
            Assert.Equal(FechaIngreso, estadia.FechaIngreso);

            Assert.NotNull(estadia.FechaSalida);
            Assert.Equal(FechaSalida, estadia.FechaSalida);

        }
        
    }
}