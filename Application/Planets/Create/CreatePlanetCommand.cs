using MediatR;

namespace Application.Planets.Create;

public record CreatePlanetCommand(
    string Name,
    double OrbitalRadius,
    double OrbitalPeriod,
    double RotationPeriod
) : IRequest<Unit>;

