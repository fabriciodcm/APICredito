using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICredito.Domain.Models
{
    public enum ETipoCredito
    {
        Direto = 1,
        Consignado,
        PessoaJuridica,
        PessoaFisica,
        Imobiliaria
    }
}
