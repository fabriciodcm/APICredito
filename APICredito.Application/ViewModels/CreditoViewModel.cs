namespace APICredito.Application.ViewModels
{
    public class CreditoViewModel
    {
        public bool StatusCreditoAprovado { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorJuros { get; set; }
        public string? MotivoRecusa { get; set; }
        public PropostaCreditoViewModel PropostaCredito { get; set; }
    }
}
