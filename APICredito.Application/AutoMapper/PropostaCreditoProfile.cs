using APICredito.Application.ViewModels;
using APICredito.Domain.Models;
using AutoMapper;

namespace APICredito.Application.AutoMapper
{
    public class PropostaCreditoProfile : Profile
    {
        public PropostaCreditoProfile() 
        {
            CreateMap<PropostaCreditoViewModel, PropostaCredito>()
                 .ConstructUsing(pc => new PropostaCredito(pc.ValorCredito, (int)pc.TipoCredito,pc.QuantidadeParcelas,pc.DataPrimeiroVencimento));

            CreateMap<PropostaCredito, PropostaCreditoViewModel>();

        }
    }
}
