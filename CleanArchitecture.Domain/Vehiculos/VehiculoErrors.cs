using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehiculos;

public static class VehiculoErrors
{
    public static Error NotFound = new("Vehiculo.Found", "No existe el vehiculo buscado por este ID");
}
