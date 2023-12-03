using APICredito.Domain.Interfaces.Core;

namespace APICredito.Domain.Core
{
    public class CalculaCreditoDiretoCore : CalculaCreditoCore, ICalculaCreditoCore
    {
        public override int Taxa() => 2;
    }
}
