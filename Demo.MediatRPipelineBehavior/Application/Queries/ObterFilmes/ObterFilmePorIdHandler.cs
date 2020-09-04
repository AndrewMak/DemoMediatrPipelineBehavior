namespace Demo.MediatRPipelineBehavior.Application.Commands.AtualizarDadosCadastro
{
    using Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro;
    using Demo.MediatRPipelineBehavior.Domain.interfaces;
    using MediatR;
    using Microsoft.Extensions.Logging;
    using System.Threading;
    using System.Threading.Tasks;

    public class ObterFilmePorIdHandler : IRequestHandler<ObterFilmesPorIdQuery, Response>
    {
        private readonly ILogger<ObterFilmePorIdHandler> _logger;
        private readonly IMovieRepository _movieRepository;
        public ObterFilmePorIdHandler(ILogger<ObterFilmePorIdHandler> logger, IMovieRepository movieRepository)
        {
            _logger = logger;
            _movieRepository = movieRepository;
        }
        public async Task<Response> Handle(ObterFilmesPorIdQuery request, CancellationToken cancellationToken)
        {
            Response response = new Response();

            _logger.LogInformation($"Iniciando o Handle de obter filme por Id : {request.Id}");

            var filme = await _movieRepository.ObterPorId(request.Id);

            if (filme is null)
                response.AddError("O filme não encontrado");

            return response;
        }
    }
}
