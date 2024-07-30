namespace Herencia;

public class Program
{
    public static void Main()
    {
        // herencia

        /*
         este pilar en POO, consiste en dos conceptos bases fáciles de entender, la clase padre y la clase hija.
         El mecanismo consiste en reutilizar código, haciendo que las propiedades y los métodos de la clase padre 
         también las pueda usar la clase hija (depende del modificador de acceso), las clases hijas también pueden 
         tener sus métodos y propiedades propios y sobreescribir las de su clase padre.

         - clase padre --> la clase de donde las clases hijas heredan
         - clase hija --> la clase que recibe las propiedades y métodos de la clase padre
         */

        Empleado empleado1 = new Empleado("Programador", 1, "Leonardo", "1003659886"); // la clase hija hereda las propiedades 
        // y usa su constructor, entonces inicializa sus propiedades y las de la clase padre

        empleado1.MostrarInformacionEmpleado();
    }
}

public class Persona // clase padre
{
    private int _id;
    public int Id { get { return _id; } }
    public string Name { get; set; } = null!;

    private string _document = null!;
    public string Document { get { return _document; } }

    private string _title = null!;

    public Persona(int id, string name, string document)
    {
        _id = id;
        _document = document;
        Name = name;
    }
}

public class Empleado : Persona // clase hija
{
    public string Cargo { get; set; } = null!; // propiedad propia de la clase hija

    public Empleado(string cargo, int id, string name, string document) : base(id, name, document) // herencia en el constructor
    {
        Cargo = cargo;
    }

    public void MostrarInformacionEmpleado()
    {
        Console.WriteLine($"nombre: {Name}, id: {Id}, documento: {Document} y cargo: {Cargo}");
    }
}
