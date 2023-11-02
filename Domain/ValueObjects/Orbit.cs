namespace Domain.ValueObjects;

public record Orbit
{
    private Orbit(double orbitalRadius, double orbitalPeriod, double rotationPeriod)
    {
        OrbitalRadius = orbitalRadius;
        OrbitalPeriod = orbitalPeriod;
        RotationPeriod = rotationPeriod;
    }

    public double OrbitalRadius { get; init; }
    public double OrbitalPeriod { get; init; }
    public double RotationPeriod { get; init; }

    public static Orbit(double orbitalRadius, double orbitalPeriod, double rotationPeriod)
    {
        if (orbitalRadius < 0 || orbitalPeriod < 0 || rotationPeriod < 0)
        {
            return null; //TODO: add exception
        }
        return new Orbit(orbitalRadius, orbitalPeriod, rotationPeriod);
    }
}