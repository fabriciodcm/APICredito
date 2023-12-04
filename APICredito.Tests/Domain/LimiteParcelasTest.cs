using APICredito.Domain.Models;

namespace APICredito.Tests.Domain
{
    public class LimiteParcelasTest
    {
        [Fact]
        public void LimiteInvalidoSuperior()
        {

            Action validate = () => new PropostaCredito(1000000, (int)ETipoCredito.Consignado, 73, DateTime.Now.AddDays(16));

            Assert.Throws<InvalidOperationException>(validate);
        }
        [Fact]
        public void LimiteInvalidoInferior()
        {

            Action validate = () => new PropostaCredito(1000000, (int)ETipoCredito.Consignado, 4, DateTime.Now.AddDays(16));

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
