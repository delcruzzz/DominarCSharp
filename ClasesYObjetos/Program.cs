namespace ClasesYObjetos;

// clases y objetos

/*
 las clases son estructuras o entidades que sirven como guías para la creación de objetos, estas 
 tienen caracteristicas y funcionalidades generales.

 los objetos son instancias de las clases, ellos le dan valor a las caracteristicas y usan las 
 funcionalidades de la clase
 */
public class Program
{
    public static void Main()
    {
        // objeto
        Vehiculo carro = new Vehiculo(5, "KJS602", 9000);
        Console.WriteLine(carro);

        // acceder a las propiedades de la clase desde el objeto
        Console.WriteLine(carro.puertas);

        // acceder a los métodos de la clase desde el objeto
        Console.WriteLine(carro.Arrancar());
    }
}

// clase
public class Vehiculo
{
    public int puertas { get; set; }
    public string placa { get; set; } = null!;
    public int kilometraje { get; set; }
    
    // método constructor (importante)
    public Vehiculo(int _puertas, string _placa, int _kilometraje)
    {
        puertas = _puertas;
        placa = _placa;
        kilometraje = _kilometraje;
    }

    public string Arrancar()
    {
        return "Carro arrancó";
    }
}
