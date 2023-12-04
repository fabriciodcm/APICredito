using APICredito.Application.Interface.Factory;
using APICredito.Domain.Core;
using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Application.Factory
{
    public class TipoCreditoFactory : ITipoCreditoFactory
    {
        public ICalculaCreditoCore Factory(int tipo)
        {
            if (tipo == (int)ETipoCredito.Direto)
            {
                return new CalculaCreditoDiretoCore();
            }
            else if (tipo == (int)ETipoCredito.Consignado)
            {
                return new CalculaCreditoConsignadoCore();
            }
            else if (tipo == (int)ETipoCredito.PessoaJuridica)
            {
                return new CalculaCreditoPessoaJuridicaCore();
            }
            else if (tipo == (int)ETipoCredito.PessoaFisica)
            {
                return new CalculaCreditoPessoaFisicaCore();
            }
            else if (tipo == (int)ETipoCredito.Imobiliaria)
            {
                return new CalculaCreditoImobiliariaCore();
            }
            else
            {
                throw new InvalidOperationException("Tipo de crédito inválido.");
            }
        }
    }
}
