namespace MetodoConstructor;

public class Program
{
    public static void Main()
    {
        // método constructor

        /*
         es el primer método que se ejecuta apenas se instancia una clase o creamos el objeto, este 
         se debe llamar igual que la clase, además sirve para inicializar las propiedades de la clase 
         así al ser usadas, se les da valor.

         estos pueden o no tener parámetros, además pueden haber más de un constructor para la clase y el 
         lenguaje define cual usar según la necesidad (eso es sobrecarga)
         */

        Persona persona1 = new Persona(); // con el constructor vacio (las propiedades no tienen valor)
        Persona persona2 = new Persona("Leonardo"); // con el constructor que inicializa solo la propiedad name (solo la propiedad name tiene valor)
        Persona persona3 = new Persona(1, "José"); // con el constructor que inicializa todas las propiedades de la clase (las dos propiedades tienen valor)
    }
}


public class Persona
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public Persona() // constructor vacio
    {

    }

    public Persona(string name) // constructor que inicializa la propiedad name
    {
        Name = name;
    }

    public Persona(int id, string name) // constructor que inicializa todas las propiedades de la clase
    {
        Id = id;
        Name = name;
    }
}
