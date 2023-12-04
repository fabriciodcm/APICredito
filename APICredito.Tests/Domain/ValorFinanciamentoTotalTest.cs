using APICredito.Domain.Core;
using APICredito.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Tests.Domain
{
    public class ValorFinanciamentoTotalTest
    {
        [Fact]
        public void TaxaDireto()
        {
            //Arrange
            var mockCalculaDireto = new CalculaCreditoDiretoCore();

            //Act
            var result = mockCalculaDireto.Calcular(new PropostaCredito(1000, (int)ETipoCredito.Direto, 12, DateTime.Now.AddDays(16)));

            //Assert
            Assert.Equal(1020, result.ValorTotal);
        }

        [Fact]
        public void TaxaConsignado()
        {
            //Arrange
            var mockCalculaConsignado = new CalculaCreditoConsignadoCore();

            //Act
            var result = mockCalculaConsignado.Calcular(new PropostaCredito(1000, (int)ETipoCredito.Consignado, 12, DateTime.Now.AddDays(16)));

            //Assert
            Assert.Equal(1010, result.ValorTotal);
        }

        [Fact]
        public void TaxaPessoaJuridica()
        {
            //Arrange
            var mockCalculaPJuridica = new CalculaCreditoPessoaJuridicaCore();

            //Act
            var result = mockCalculaPJuridica.Calcular(new PropostaCredito(20000, (int)ETipoCredito.PessoaJuridica, 12, DateTime.Now.AddDays(16)));

            //Assert
            Assert.Equal(21000, result.ValorTotal);
        }

        [Fact]
        public void TaxaPessoaFisica()
        {
            //Arrange
            var mockCalculaPFisica = new CalculaCreditoPessoaFisicaCore();

            //Act
            var result = mockCalculaPFisica.Calcular(new PropostaCredito(1000, (int)ETipoCredito.PessoaFisica, 12, DateTime.Now.AddDays(16)));

            //Assert
            Assert.Equal(1030, result.ValorTotal);
        }

        [Fact]
        public void TaxaImobiliario()
        {
            //Arrange
            var mockCalculaImob = new CalculaCreditoImobiliariaCore();

            //Act
            var result = mockCalculaImob.Calcular(new PropostaCredito(1000, (int)ETipoCredito.Imobiliaria, 12, DateTime.Now.AddDays(16)));

            //Assert
            Assert.Equal(1090, result.ValorTotal);
        }
    }
}
