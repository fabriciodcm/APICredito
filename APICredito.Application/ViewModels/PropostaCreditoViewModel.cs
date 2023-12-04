using APICredito.Domain.Models;
using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace APICredito.Application.ViewModels
{
    public class PropostaCreditoViewModel
    {
        [Min(0)]
        public decimal ValorCredito { get; set; }
        public ETipoCredito TipoCredito { get; set; }
        [Range(1, int.MaxValue)]
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
