using APICredito.Application.Interface.Services;
using APICredito.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace APICredito.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditosController : ControllerBase
    {
        private readonly ICalcularCreditoService _service;
        public CreditosController(ICalcularCreditoService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<CreditoViewModel> Post([FromBody] PropostaCreditoViewModel Proposta)
        {
            try
            {
                CreditoViewModel Credito = _service.CalcularCredito(Proposta);
                return Accepted(Credito);
            }
            catch (InvalidOperationException invalidEx)
            {
                return StatusCode(StatusCodes.Status406NotAcceptable, new CreditoViewModel { MotivoRecusa = invalidEx.Message, StatusCreditoAprovado = false, PropostaCredito = Proposta });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
