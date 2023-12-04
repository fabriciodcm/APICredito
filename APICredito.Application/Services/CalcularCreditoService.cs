using APICredito.Application.Interface.Factory;
using APICredito.Application.Interface.Services;
using APICredito.Application.ViewModels;
using APICredito.Domain.Interfaces.Core;
using APICredito.Domain.Models;
using AutoMapper;

namespace APICredito.Application.Services
{
    public class CalcularCreditoService : ICalcularCreditoService
    {
        private readonly IMapper _mapper;
        private readonly ITipoCreditoFactory _factory;

        public CalcularCreditoService(IMapper mapper, ITipoCreditoFactory factory) 
        {
            _mapper = mapper;
            _factory = factory;
        }

        public CreditoViewModel CalcularCredito(PropostaCreditoViewModel Proposta) 
        {
            ICalculaCreditoCore core = _factory.Factory((int)Proposta.TipoCredito);
            
            Credito credito = core.Calcular(_mapper.Map<PropostaCredito>(Proposta));

            return _mapper.Map<CreditoViewModel>(credito);
        }
    }
}
