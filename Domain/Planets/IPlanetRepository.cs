namespace Domain.Planet;

public interface IPlanetRepository
{
    Task<Planet> GetByIdAsync(PlanetId id);
    Task Add(Planet planet);
}