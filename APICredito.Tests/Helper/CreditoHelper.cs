using APICredito.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Tests.Helper
{
    public class CreditoHelper
    {
        public static Credito getCreditoPropostaValida()
        {
            var proposta = new PropostaCredito(1000, "Credito", 12, DateTime.Now.AddDays(16));
            return new Credito(false, 0, 0, proposta);
        }

        public static Credito getCreditoPropostaValidaPessoaJuridica()
        {
            var proposta = new PropostaCredito(18000, "Credito", 12, DateTime.Now.AddDays(16));
            return new Credito(false, 0, 0, proposta);
        }
    }
}
