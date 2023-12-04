using APICredito.Application.ViewModels;
using APICredito.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Application.AutoMapper
{
    public class CreditoProfile : Profile
    {
        public CreditoProfile() 
        {
            CreateMap<CreditoViewModel, Credito>()
                 .ConstructUsing(c => new Credito(c.StatusCreditoAprovado,c.ValorTotal,c.ValorJuros,
                    new PropostaCredito(c.PropostaCredito.ValorCredito,(int)c.PropostaCredito.TipoCredito,c.PropostaCredito.QuantidadeParcelas,c.PropostaCredito.DataPrimeiroVencimento)));

            CreateMap<Credito, CreditoViewModel>();
        }
    }
}
