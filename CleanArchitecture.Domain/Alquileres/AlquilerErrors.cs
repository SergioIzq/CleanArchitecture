using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Alquileres;

public static class AlquilerErrors
{
    public static Error NotFound = new(
            "Alquiler.Found", 
            "El Alquiler con el id especificado no fue encontrado"
        );

    public static Error Overlap = new(
            "Alquiler.Overlap", 
            "El Alquiler está siendo tomado por dos o más clientes al mismo tiempo en la misma fecha"
        );

    public static Error NotReserved = new(
            "Alquiler.NotReserved",
            "El Alquiler no está reservado"
        );

    public static Error NotConfirmed = new(
        "Alquiler.NotConfirmed",
        "El Alquiler no está confirmado"
    );

    public static Error AlreadyStarted = new(
        "Alquiler.AlreadyStarted",
        "El Alquiler ya ha comenzado"
    );
}
