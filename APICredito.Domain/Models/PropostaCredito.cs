using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Domain.Models
{
    public class PropostaCredito 
    {
        public PropostaCredito(decimal ValorCredito, string TipoCredito, int QuantidadeParcelas, DateTime   DataPrimeiroVencimento)
        {
            if(ValorCredito > 1000000) 
            {
                throw new InvalidOperationException("Valor de crédito Excede R$1.000.000,00.");
            }

            if (QuantidadeParcelas > 72 || QuantidadeParcelas < 5)
            {
                throw new InvalidOperationException("Valor de parcelas inválido.");
            }

            if (DataPrimeiroVencimento > DateTime.Now.AddDays(40) || DataPrimeiroVencimento < DateTime.Now.AddDays(15)) 
            {
                throw new InvalidOperationException("Data de primeira parcela inválida, não pode ser inferior a 15 dias ou superior a 40 dias da data atual.");
            }


                

            this.ValorCredito = ValorCredito;
            this.QuantidadeParcelas = QuantidadeParcelas;
            this.DataPrimeiroVencimento = DataPrimeiroVencimento;
            this.TipoCredito = TipoCredito;
        }

        public decimal ValorCredito { get; protected set; }
        public string TipoCredito { get; protected set; } = string.Empty;
        public int QuantidadeParcelas { get; protected set; }
        public DateTime DataPrimeiroVencimento { get; protected set; }
    }
}
