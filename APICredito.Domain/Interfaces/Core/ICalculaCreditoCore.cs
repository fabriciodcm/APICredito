using APICredito.Domain.Models;

namespace APICredito.Domain.Interfaces.Core
{
    public interface ICalculaCreditoCore
    {
        int Taxa();
        Credito Carcular(PropostaCredito Proposta);
    }
}
