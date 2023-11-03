using Domain.Primitives;
using Domain.ValueObjects;

namespace Domain.Planet;

public sealed class Planet : AggregateRoot
{
    public Planet(PlanetId id, string name, Orbit orbit)
    {
        Id = id;
        Name = name;
        Orbit = orbit;
    }

    private Planet()
    {

    }

    public PlanetId Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Orbit Orbit { get; private set; }
}