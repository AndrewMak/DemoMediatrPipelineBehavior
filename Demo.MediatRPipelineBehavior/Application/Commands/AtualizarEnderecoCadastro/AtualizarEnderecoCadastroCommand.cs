namespace Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro
{
    using MediatR;

    public class AtualizarEnderecoCadastroCommand : IRequest<Response>
    {
        public AtualizarEnderecoCadastroCommand(string endereco, decimal numero)
        {
            Endereco = endereco;
            Numero = numero;
        }
        public string Nome { get; private set; }

        public string SobreNome { get; private set; }

        public decimal Numero { get; private set; }

        public string Endereco { get; private set; }

    }
}
