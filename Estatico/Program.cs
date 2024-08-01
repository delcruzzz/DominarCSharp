namespace Estatico;

public class Program
{
    public static void Main()
    {
        // static

        /*
         es un modificar, que se utiliza para definir miembros (atributos, métodos, propiedades, etc.) de una clase que pertenecen 
         a la clase misma en lugar de a una instancia específica de la clase. Esto significa que puedes acceder a un miembro static 
         sin crear una instancia de la clase.
         */

        // la podemos llamar desde la clase, no necesitamos instanciarlas (propiedades)
        Console.WriteLine(Contador.TotalContador);

        // los podemos llamar desde la clase, no necesitamos instanciarlas (métodos)
        Contador.Incrementar();

        Console.WriteLine(Contador.TotalContador);
    }
}

public class Contador()
{
    // propiedad estática
    public static int TotalContador;

    // método estático
    public static void Incrementar()
    {
        TotalContador += 1;
    }
}
