using APICredito.Domain.Models;

namespace APICredito.Tests.Domain
{
    public class LimiteCreditoTest
    {
        [Fact]
        public void LimiteInvalido()
        {
            
            Action validate = () => new PropostaCredito(1000001 , (int)ETipoCredito.Consignado, 24, DateTime.Now.AddDays(16) );
          
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
