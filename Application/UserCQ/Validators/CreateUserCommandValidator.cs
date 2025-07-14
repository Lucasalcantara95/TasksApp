using Application.UserCQ.Commands;
using FluentValidation;

namespace Application.UserCQ.Validators
{
	public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
	{
		public CreateUserCommandValidator()
		{
			RuleFor(x => x.Email)
				.NotEmpty().WithMessage("O campo 'Email' não pode ser vazio.")
				.EmailAddress().WithMessage("O campo 'Email' deve ser um endereço de email válido.");


			RuleFor(X => X.Username)
				.MinimumLength(1).WithMessage("O campo 'Username' não pode estar vazio.");
		
		}
	}
}
