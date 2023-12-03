using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;

namespace APICredito.Domain.Core
{
    public class CalculaCreditoPessoaJuridicaCore : CalculaCreditoCore, ICalculaCreditoCore
    {
        public override int Taxa() => 5;

        public override Credito Carcular(PropostaCredito Proposta)
        {
            if(Proposta.ValorCredito < 15000) 
            {
                throw new InvalidOperationException("Valor inferior ao mínimo para pessoa física.");
            }

            return base.Carcular(Proposta);
        }
    }
}
