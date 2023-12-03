using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;

namespace APICredito.Domain.Core
{
    public abstract class CalculaCreditoCore : ICalculaCreditoCore
    {
        public virtual Credito Carcular(PropostaCredito Proposta)
        {
            var juros = Proposta.ValorCredito * (Taxa() / 100);
            var valorTotal = Proposta.ValorCredito + juros;
            return new Credito(true, valorTotal, juros , Proposta) ;
        }

        public abstract int Taxa();
    }
}
