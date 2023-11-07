using Application.Planets.Common;
using ErrorOr;
using MediatR;

namespace Application.Planets.GetAll
{
    public record GetAllPlanetsQuery() : IRequest<ErrorOr<IReadOnlyList<PlanetResponse>>>;
}

