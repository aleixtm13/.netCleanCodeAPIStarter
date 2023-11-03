using Domain.Planet;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{
    DbSet<Planet> Planets { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}