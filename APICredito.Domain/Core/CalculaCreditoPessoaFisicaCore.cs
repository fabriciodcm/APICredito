using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;

namespace APICredito.Domain.Core
{
    public class CalculaCreditoPessoaFisicaCore : CalculaCreditoCore, ICalculaCreditoCore
    {
        public override int Taxa() => 3;
    }
}
