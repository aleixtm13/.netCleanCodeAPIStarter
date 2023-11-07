namespace Domain.Planet;

public interface IPlanetRepository
{
    Task<List<Planet>> GetAll();
    Task<Planet?> GetByIdAsync(PlanetId id);
    Task Add(Planet planet);
}