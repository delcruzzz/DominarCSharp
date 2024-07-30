namespace SobrecargaDeMetodos;

public class Program
{
    public static void Main()
    {
        // la sobrecarga

        /*
         consiste en una serie de métodos con el mismo nombre y que posiblemente hagan la misma 
         acción pero la diferencia es su cantidad de parámetros, los tipos de sus parámetros y su 
         tipo de retorno, un método se puede sobrecargar la cantidad de veces que querramos.
         */

        Console.WriteLine(Sumar(2, 5)); // sumar con dos enteros, que retorna un entero
        Console.WriteLine(Sumar(3, 4, 5)); // sumar con tres enteros, que retorna un entero
        Console.WriteLine(Sumar("Leonardo ", "José")); // concatena dos strings, que retorna un string
    }

    public static int Sumar(int a, int b) // método Sumar
    {
        return a + b;
    }

    public static int Sumar(int a, int b, int c) // sobrecarga 1 del método Sumar
    {
        return a + b + c;
    }

    public static string Sumar(string a, string b) // sobrecarga 2 del método Sumar
    {
        return a + b;
    }
}
