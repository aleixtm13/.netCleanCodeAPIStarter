using ErrorOr;

namespace Domain.DomainErrors;

public static partial class Errors
{
    public static class Planet
    {
        public static Error OrbitWithBadFormat => Error.Validation("Planet.Orbit", "Planet Orbit Has no valid format");
    }
}