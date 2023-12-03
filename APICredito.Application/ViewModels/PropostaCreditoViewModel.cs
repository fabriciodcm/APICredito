namespace APICredito.Application.ViewModels
{
    public class PropostaCreditoViewModel
    {
        public decimal ValorCredito { get; set; }
        public string TipoCredito { get; set; } = string.Empty;
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
