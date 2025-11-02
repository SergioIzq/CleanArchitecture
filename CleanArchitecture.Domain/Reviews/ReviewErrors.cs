using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Reviews
{
    public static class ReviewErrors
    {
        public static readonly Error NotEligible = new(
            "Error.NotEligible",
            "Este review y calificación para el vehículo no es elegible porque no se ha completado"
        );
    }
}
