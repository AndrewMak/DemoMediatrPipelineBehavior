namespace Demo.MediatRPipelineBehavior.Controllers.v1
{
    using Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    [ApiController]
    [Produces("application/json")]
    [Route("api/cadastro")]
    public class CadastroController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CadastroController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> AtualizarDadosCadastro(string id, string endereco, decimal numero)
        {
            var response = await _mediator.Send(new AtualizarEnderecoCadastroCommand(endereco, numero));

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }

            return Ok(response.Result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> ObterFilmePorId(string id)
        {
            //chama o handler desse obterfilmesporidquery -> ObterFilmePorIdHandler
            var response = await _mediator.Send(new ObterFilmesPorIdQuery(id));

            //verifica se tem alguma mensagem de domininio para retornar pro usuario, por exemplo que o filme está com atraso de devolução.
            if (response.HasMessages)
            {
                return BadRequest(response.Errors);
            }

            
            return Ok(response.Result);
        }
    }
}
