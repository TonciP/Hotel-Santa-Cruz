using Reserva.Domain.Model.Clientes;

namespace TestCliente
{
    public class UnitTest1
    {
        [Fact]
        public void ClientCreation_Should_Correct()
        {
            //Guid clienteId = Guid.NewGuid();
            string nombres = "Marcos Antonio";
            string apellidos = "Mercado Aguirre";
            string email = "56350a@nur.edu";
            string direccion = "B/ Navidad";
            string telefono = "77777777";

            Cliente cliente = new Cliente(nombres, apellidos, email, direccion, telefono);

            Assert.NotNull(cliente.Nombres);
            Assert.Equal(nombres, cliente.Nombres);
            Assert.NotNull(cliente.Apellidos);
            Assert.NotNull(cliente.Email);
            Assert.NotNull(cliente.Direccion);
            Assert.NotNull(cliente.Telefono);

        }
    }
}