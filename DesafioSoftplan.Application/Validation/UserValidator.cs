using DesafioSoftplan.Services.Dtos;
using FluentValidation;
using System;

namespace DesafioSoftplan.Services.Validation
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("O campo Nome é obrigatório.");
            RuleFor(x => x.Email).NotNull().WithMessage("O campo de E-mail é obrigatório.").EmailAddress().WithMessage("O E-mail informado é inválido.");
            RuleFor(x => x.Street).NotNull().WithMessage("O campo Rua é obrigatório.");
            RuleFor(x => x.Number).NotNull().WithMessage("O campo Número é obrigatório.");
            RuleFor(x => x.District).NotNull().WithMessage("O campo Bairro é obrigatório.");
            RuleFor(x => x.City).NotNull().WithMessage("O campo Cidade é obrigatório.");
            RuleFor(x => x.State).NotNull().WithMessage("O campo Estado é obrigatório.");
        }
    }

}