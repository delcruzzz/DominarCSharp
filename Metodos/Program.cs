namespace Metodos;

public class Program
{
    public static void Main()
    {
        // métodos

        /*
         es un bloque de código que realiza una tarea especifica y que puede ser llamado (invocado) desde otras partes del
         programa y la funcionalidad relacionada en un lungar centralizado y reutilizable en todo el programa.

         Cada método tiene un nombre único y una lista de parámetros que se utilizan para pasar información al método y, 
         opcionalmente, devolver información al código que lo invoca.

         - modificador
         - tipo de retorno
         - nombre del método
         - [parámetros]
         */

        int[] numeros = { 1, 2, 3, 4, 5 };

        Console.WriteLine(Sumar(2, 5));
        ReciboArreglo(numeros);

        Console.WriteLine(TengoParametroPorDefecto(4, 5)); // sin el último parámetro
        Console.WriteLine(TengoParametroPorDefecto(4, 2, 3)); // con el último parámetro
    }

    // método
    public static int Sumar(int a, int b) // los parámetros son las variables locales del método y el cual al ser llamado el método
        // se les pasa valor
    {
        return a + b; // return, como su nombre lo dice retorna un valor o un resultado de lo que hagamos en la función
    }

    public static void ReciboArreglo(int[] numeros) // void signica vacio, esta función no retorna ningún valor o resultado
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    public static int TengoParametroPorDefecto(int num1, int num2, int num3 = 0) // se le da valor al parámetro por defecto ya que si 
        // no se le envia valor al ser llamado toma el valor que se le asignó
    {
        return num1 + num2 + num3;
    }
}
