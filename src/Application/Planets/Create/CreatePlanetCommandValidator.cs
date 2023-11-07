using FluentValidation;

namespace Application.Planets.Create;

public class CreatePlanetCommandValidator : AbstractValidator<CreatePlanetCommand>
{
    public CreatePlanetCommandValidator()
    {
        RuleFor(planet => planet.Name).NotEmpty()
        .MaximumLength(50);
    }
}