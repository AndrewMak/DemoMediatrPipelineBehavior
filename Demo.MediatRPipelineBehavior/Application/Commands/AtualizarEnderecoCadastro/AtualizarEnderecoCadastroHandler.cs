namespace Demo.MediatRPipelineBehavior.Application.Commands.AtualizarDadosCadastro
{
    using Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using System.Threading;
    using System.Threading.Tasks;

    public class AtualizarEnderecoCadastroHandler : IRequestHandler<AtualizarEnderecoCadastroCommand, Response>
    {
        private readonly ILogger<AtualizarEnderecoCadastroHandler> _logger;
        public AtualizarEnderecoCadastroHandler(ILogger<AtualizarEnderecoCadastroHandler> logger)
        {
            _logger = logger;
        }
        public Task<Response> Handle(AtualizarEnderecoCadastroCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Propriedade Nome:{request.Endereco}");

            return Task.FromResult(new Response(request));
        }
    }
}
