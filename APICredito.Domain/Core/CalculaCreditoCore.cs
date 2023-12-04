using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;

namespace APICredito.Domain.Core
{
    public abstract class CalculaCreditoCore : ICalculaCreditoCore
    {
        public virtual Credito Calcular(PropostaCredito Proposta)
        {
            decimal taxa = Taxa();

            var juros = Proposta.ValorCredito * (taxa / 100M);

            var valorTotal = Proposta.ValorCredito + juros;
            
            return new Credito(true, valorTotal, juros , Proposta) ;
        }

        public abstract int Taxa();
    }
}
