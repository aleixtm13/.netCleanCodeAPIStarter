using Application.Planets.Common;
using Domain.Planet;
using ErrorOr;
using MediatR;

namespace Application.Planets.GetAll
{
    public class GetAllPlanetsQueryHandler : IRequestHandler<GetAllPlanetsQuery, ErrorOr<IReadOnlyList<PlanetResponse>>>
	{
		private readonly IPlanetRepository _planetRepository;

        public GetAllPlanetsQueryHandler(IPlanetRepository planetRepository)
        {
            _planetRepository = planetRepository ?? throw new ArgumentNullException(nameof(planetRepository));
        }

        public async Task<ErrorOr<IReadOnlyList<PlanetResponse>>> Handle(GetAllPlanetsQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Planet> planets = await _planetRepository.GetAll();
            return planets.Select(planet => new PlanetResponse(
            
                planet.Id.Value,
                planet.Name,
                new OrbitResponse(
                    planet.Orbit.OrbitalRadius,
                    planet.Orbit.OrbitalPeriod,
                    planet.Orbit.RotationPeriod
                    )

            )).ToList();
        }
    }
}

