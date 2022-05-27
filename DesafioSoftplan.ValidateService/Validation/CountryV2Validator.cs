using DesafioSoftplan.Services.Dtos;
using FluentValidation;

namespace DesafioSoftplan.Services.Validation
{
    public class CountryV2Validator : AbstractValidator<CountryV2Dto>
        {
            public CountryV2Validator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("O campo Nome é obrigatório.");
            RuleFor(x => x.Area).NotNull().WithMessage("O campo Área é obrigatório.");
            RuleFor(x => x.Population).NotNull().WithMessage("O campo População é obrigatório.");
            RuleFor(x => x.Capital).NotNull().WithMessage("O campo Capital é obrigatório.");
            RuleFor(x => x.OfficialLanguages).NotNull().WithMessage("O campo Capital é obrigatório.");
        }
    }

}