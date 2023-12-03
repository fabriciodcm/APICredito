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

            var proposta = new PropostaCredito(1000, "Credito", 12, DateTime.Now.AddDays(16));

            //Act
            Action action = () => mockCalculaDireto.Carcular(proposta);

            //Assert
            Assert.Throws<InvalidOperationException>(action);
        }

        [Fact]
        public void ValorPessoaJuridicaValida()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoPessoaJuridicaCore();

            var proposta = new PropostaCredito(18000, "Credito", 12, DateTime.Now.AddDays(16));

            //Act
            var result =  mockCalculaDireto.Carcular(proposta);

            //Assert
            Assert.IsType<Credito>(result);
        }
    }
}
