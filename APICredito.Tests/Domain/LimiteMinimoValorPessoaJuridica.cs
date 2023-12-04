using APICredito.Domain.Core;
using APICredito.Domain.Models;

namespace APICredito.Tests.Domain
{
    public class LimiteMinimoValorPessoaJuridica
    {
        [Fact]
        public void ValorPessoaJuridicaInvalida()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoPessoaJuridicaCore();

            var proposta = new PropostaCredito(1000, (int)ETipoCredito.PessoaJuridica, 12, DateTime.Now.AddDays(16));

            //Act
            Action action = () => mockCalculaDireto.Calcular(proposta);

            //Assert
            Assert.Throws<InvalidOperationException>(action);
        }

        [Fact]
        public void ValorPessoaJuridicaValida()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoPessoaJuridicaCore();

            var proposta = new PropostaCredito(18000, (int)ETipoCredito.PessoaJuridica, 12, DateTime.Now.AddDays(16));

            //Act
            var result =  mockCalculaDireto.Calcular(proposta);

            //Assert
            Assert.IsType<Credito>(result);
        }
    }
}
