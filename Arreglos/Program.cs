namespace Arreglos;

public class Program
{
    public static void Main()
    {
        // arreglos

        /*
         es una variable que pueda almacenar más de un solo valor, de forma estructural y 
         ordenada por pocisiones (solo del tipo que establecimos son los valores que guardamos)

         son inmutables
         */

        int[] numeros = { 1, 2, 3, 4, 5 }; // creación de arreglo con asignación de valores --> no son mutables

        /*
         sus pocisiones van desde el 0 hasta n (último índice que establescas), con esto ya podemos acceder a sus 
         posiciones y valores
         */

        string[] nombres = new string[5];

        nombres[0] = "Leonardo"; // agregar valor a la posición 0 y así sucesivamente
        nombres[1] = "Jose";
        nombres[2] = "Claudia";
        nombres[3] = "Devis";
        nombres[4] = "Antonio"; // cuando queremos cambiar el valor de esa pocisión también búscamos la posición y le asignamos un valor

        // iterar arreglos
        // -- for
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        // propiedades
        Console.WriteLine(numeros.Length); // nos retorna la longitud del arreglo

        // métodos
        Array.Sort(nombres); // organizar de forma ascendente
        Array.Reverse(nombres); // organizar de forma descendente
        Array.IndexOf(numeros, 2); // busca la primera vez en la que se encuentra la coincidencia y retorna su índice sino -1
        Array.Find(numeros, num => num > 2); // busca el primer elemento que cumpla con la condición y retorna el elemento
        Array.Exists(nombres, nom => nom.Length > 4); // busca en el array si algún elemento cumple con la condición y si existe retorna true sino false
        numeros.Where(num => num % 2 == 0); // filtra por los elementos y retorna los que cumplan con la condición
        numeros.Select(num => num * 4); // transforma los elementos del arreglo, con la operación que se establesca
    }
}
