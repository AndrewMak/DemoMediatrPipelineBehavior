namespace Demo.MediatRPipelineBehavior.Application.Commands.AtualizarEnderecoCadastro
{
    using FluentValidation;
    public class AtualizarEnderecoCadastroValidator : AbstractValidator<AtualizarEnderecoCadastroCommand>
    {
        public AtualizarEnderecoCadastroValidator()
        {
            RuleFor(x => x.Endereco)
                .NotEmpty()
                .WithErrorCode("EnderecoInvalido")
                .WithMessage("O Endereço deve ser preenchido."); ;

            RuleFor(x => x.Numero)
                .GreaterThan(0)
                .WithErrorCode("ValorInvalido")
                .WithMessage("Numero não deve ser menor que 1.");
        }
    }
}
