namespace Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro
{
    using MediatR;

    //aqui seria o request que vc quer filtrar na query...
    public class ObterFilmesPorIdQuery : IRequest<Response>
    {
        public ObterFilmesPorIdQuery(string id)
        {
            Id = id;
        }
        public string Id { get; private set; }

    }
}
