using Domain.Planet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configuration;

public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
{
    public void Configure(EntityTypeBuilder<Planet> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
        .HasConversion(planetId => planetId.Value,
                        value => new PlanetId(value));

        builder.Property(p => p.Name).HasMaxLength(50);

        builder.OwnsOne(p => p.Orbit, orbitBuilder =>
        {
            orbitBuilder.Property(o => o.OrbitalPeriod).IsRequired(false);
            orbitBuilder.Property(o => o.OrbitalRadius).IsRequired(false);
            orbitBuilder.Property(o => o.RotationPeriod).IsRequired(false);
        });
    }
}