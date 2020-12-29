using CommandAPI.Dtos;
using FluentValidation;

namespace CommandAPI.ModelValidation
{
    public class CommandUpdateDtoValidator : AbstractValidator<CommandUpdateDto>
    {
        public CommandUpdateDtoValidator()
        {
            RuleFor(x => x.CommandLine).NotNull();
            RuleFor(x => x.HowTo).NotNull().MaximumLength(10).NotEmpty();
            RuleFor(x => x.Platform).NotNull().NotEmpty();
        }

        public override void EnsureInstanceNotNull(object instanceToValidate)
        {

        }

    }
}
