namespace Interfaces;

public class Program
{
    public static void Main()
    {
        // interfaces

        /*
         una interfaz es un contrato que define un conjunto de miembros (métodos, propiedades, eventos, indexadores) que una clase o 
         estructura debe implementar. A diferencia de las clases, una interfaz no puede contener implementación de métodos; solo 
         declara qué miembros deben estar presentes.
         */

        // usar la interfaz como un tipo
        IVehiculo vehiculo = new Coche();

        Console.WriteLine(vehiculo.Velocidad);
    }
}

// definición de una interfaz
public interface IVehiculo
{
    void Conducir(); // tipo del método
    int Velocidad { get; set; } // tipo de la propiedad
}

// implementación de una interfaz
public class Coche : IVehiculo
{
    public int Velocidad { get; set; }

    public void Conducir()
    {
        Console.WriteLine("El coche se está conduciendo.");
    }

    // uso de interfaz como tipo de dato
    public void MoverVehiculo(IVehiculo vehiculo)
    {
        vehiculo.Conducir();
    }
}
