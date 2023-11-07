using Domain.Planet;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Repositories;

public class PlanetRepository : IPlanetRepository
{
    private readonly ApplicationDbContext _context;

    public PlanetRepository(ApplicationDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task Add(Planet planet) => await _context.Planets.AddAsync(planet);

    public async Task<List<Planet>> GetAll() => await _context.Planets.ToListAsync();

    public async Task<Planet?> GetByIdAsync(PlanetId id) => await _context.Planets.SingleOrDefaultAsync(planet => planet.Id.Equals(id));
}