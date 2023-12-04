using APICredito.Domain.Interfaces.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Application.Interface.Factory
{
    public interface ITipoCreditoFactory
    {
        ICalculaCreditoCore Factory(int tipo);
    }
}
