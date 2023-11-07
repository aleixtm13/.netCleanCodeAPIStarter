using Domain.Planet;
using Domain.Primitives;
using Domain.DomainErrors;
using Application.Planets.Create;

namespace Application.Planets.UnitTests.Create;

public class CreatePlanetCommandHandlerUnitTests
{
    private readonly Mock<IPlanetRepository> _mockPlanetRepository;
    private readonly Mock<IUnitOfWork> _mockUnitOfWork;

    private readonly CreatePlanetCommandHandler _handler;
    public CreatePlanetCommandHandlerUnitTests()
    {
        _mockPlanetRepository = new Mock<IPlanetRepository>();
        _mockUnitOfWork = new Mock<IUnitOfWork>();
        _handler = new CreatePlanetCommandHandler(_mockPlanetRepository.Object, _mockUnitOfWork.Object);
    }

    [Fact]
    public async void HandleCreatePlanetCommandHandler_WhenOrbitHasInvalidFormat_ShouldReturnValidationError()
    {
        // Arrange
        var command = new CreatePlanetCommand("TestPlanet", -1, 1, 1);
        // Act
        var result = await _handler.Handle(command, default);
        // Assert
        result.IsError.Should().BeTrue();
        result.FirstError.Type.Should().Be(ErrorType.Validation);
        result.FirstError.Code.Should().Be(Errors.Planet.OrbitWithBadFormat.Code);
        result.FirstError.Description.Should().Be(Errors.Planet.OrbitWithBadFormat.Description);

    }
}