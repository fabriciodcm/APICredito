using APICredito.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace APICredito.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditosController : ControllerBase
    {
        [HttpPost]
        public ActionResult<CreditoViewModel> Post([FromBody] PropostaCreditoViewModel Proposta)
        {
            try
            {
                return Accepted();
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
