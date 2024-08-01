namespace Genericos;

public class Program
{
    public static void Main()
    {
        // los genericos

        /*
         son una caracteristica poderosa que permite definir clases, interfaces, estructuras, métodos y delegados con un tipo de 
         dato parámetrizado. Esto significa que puedes crear una clase o método que opere con cualquer tipo de dato sin comprometer 
         la seguridad de los tipos. Los genericos proporcionan flexibilidad y reutilización de código, reduciendo la necesidad de 
         la duplicación de código y mejorando la eficiencia del código.
         */

        var cajaDeEnteros = new Caja<int>(123);
        Console.WriteLine(cajaDeEnteros.ObtenerContenido()); // Imprime: 123

        var cajaDeCadenas = new Caja<string>("Hola");
        Console.WriteLine(cajaDeCadenas.ObtenerContenido()); // Imprime: Hola
    }
}

// uso de genéricos en clases
public class Caja<T>
{
    // uso de genéricos en propiedades
    private T contenido;

    // uso de genéricos en métodos (contructor)
    public Caja(T contenido)
    {
        this.contenido = contenido;
    }

    // uso de genéricos como tipo de retorno en un método
    public T ObtenerContenido()
    {
        return contenido;
    }

    // uso de genéricos cómo tipo de un parámtro en un método
    public void CambiarContenido(T nuevoContenido)
    {
        this.contenido = nuevoContenido;
    }
}
