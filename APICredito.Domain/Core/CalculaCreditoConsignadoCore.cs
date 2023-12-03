using APICredito.Domain.Interfaces.Core;

namespace APICredito.Domain.Core
{
    public class CalculaCreditoConsignadoCore  : CalculaCreditoCore, ICalculaCreditoCore
    {
        public override int Taxa() => 1;
    }
}
