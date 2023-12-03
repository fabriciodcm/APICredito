using APICredito.Domain.Core;
using APICredito.Tests.Helper;
using Moq;


namespace APICredito.Tests.Domain
{
    public class TaxaTest
    {
        [Fact]
        public void TaxaDireto()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoDiretoCore();
                
            //Act
            var result = mockCalculaDireto.Taxa();

            //Assert
            Assert.Equal(2,result);
        }

        [Fact]
        public void TaxaConsignado()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoConsignadoCore();

            //Act
            var result = mockCalculaDireto.Taxa();

            //Assert
            Assert.Equal(1,result);
        }

        [Fact]
        public void TaxaPessoaJuridica()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoPessoaJuridicaCore();

            //Act
            var result = mockCalculaDireto.Taxa();

            //Assert
            Assert.Equal(5,result);
        }

        [Fact]
        public void TaxaPessoaFisica()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoPessoaFisicaCore();

            //Act
            var result = mockCalculaDireto.Taxa();

            //Assert
            Assert.Equal(3,result);
        }

        [Fact]
        public void TaxaImobiliario()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoImobiliariaCore();

            //Act
            var result = mockCalculaDireto.Taxa();

            //Assert
            Assert.Equal(9,result);
        }
    }
}
