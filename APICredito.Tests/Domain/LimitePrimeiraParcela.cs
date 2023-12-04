using APICredito.Domain.Models;

namespace APICredito.Tests.Domain
{
    public class LimitePrimeiraParcela
    {
        [Fact]
        public void LimiteInvalidoSuperior()
        {

            Action validate = () => new PropostaCredito(1000000, (int)ETipoCredito.Consignado, 24, DateTime.Now.AddDays(41));

            Assert.Throws<InvalidOperationException>(validate);
        }
        [Fact]
        public void LimiteInvalidoInferior()
        {

            Action validate = () => new PropostaCredito(1000000, (int)ETipoCredito.Consignado, 24, DateTime.Now.AddDays(14));

            Assert.Throws<InvalidOperationException>(validate);
        }

        [Fact]
        public void LimiteValido()
        {

            var credito = new PropostaCredito(1000000, (int)ETipoCredito.Consignado, 24, DateTime.Now.AddDays(16));

            Assert.IsType<PropostaCredito>(credito);
        }
    }
}
