using Application.Planets.Create;
using Application.Planets.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[Route("planets")]
public class PlanetsController : APIController
{
    private readonly ISender _mediator;

    public PlanetsController(ISender mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePlanetCommand command)
    {
        var createdPlanetResult = await _mediator.Send(command);
        return createdPlanetResult.Match(
            planet => Ok(),
            errors => Problem(errors)
        );
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var planetsResult = await _mediator.Send(new GetAllPlanetsQuery());
        return planetsResult.Match(
            planets => Ok(planets),
            errors => Problem(errors)
            );
    }
}