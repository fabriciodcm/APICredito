using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Domain.Models
{
    public class Credito
    {
        public Credito(bool StatusCreditoAprovado, decimal ValorTotal, decimal ValorJuros, PropostaCredito PropostaCredito) 
        {
            this.ValorTotal = ValorTotal;
            this.StatusCreditoAprovado = StatusCreditoAprovado;
            this.ValorJuros = ValorJuros;
            this.PropostaCredito = PropostaCredito;
        }
        public bool StatusCreditoAprovado { get; private set; }
        public decimal ValorTotal { get; private set; }
        public decimal ValorJuros { get; private set; } 
        public PropostaCredito PropostaCredito { get; private set; }
    }
}
