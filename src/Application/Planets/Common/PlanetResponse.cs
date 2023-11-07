namespace Application.Planets.Common;

public record PlanetResponse(
    Guid Id,
    string Name,
    OrbitResponse Orbit
    );

public record OrbitResponse(
    double OrbitalRadius,
    double OrbitalPeriod,
    double RotationPeriod
    );
