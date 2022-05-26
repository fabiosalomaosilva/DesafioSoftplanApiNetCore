using DesafioSoftplan.Services.Dtos;
using FluentValidation;

namespace DesafioSoftplan.Services.Validation
{
    public class CountryValidator : AbstractValidator<CountryDto>
    {
        public CountryValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("O campo Nome é obrigatório.");
            RuleFor(x => x.Area).NotNull().WithMessage("O campo Área é obrigatório.");
            RuleFor(x => x.Population).NotNull().WithMessage("O campo População é obrigatório.");
            RuleFor(x => x.Capital).NotNull().WithMessage("O campo Capital é obrigatório.");
        }
    }

}