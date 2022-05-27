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
        }
    }

}