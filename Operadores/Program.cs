namespace Operadores;

public class Program
{
    public static void Main()
    {
        // operadores

        /*
         son símbolos que representan una acción que se realiza en uno o más operandos con el fin de producir
         un resultado
         */

        // aritméticos --> operaciones matemáticas (retorna valores numéricos)
        Console.WriteLine(5 + 5); // suma
        Console.WriteLine(6 - 3); // resta
        Console.WriteLine(7 * 2); // multiplicación
        Console.WriteLine(4 / 2); // división
        Console.WriteLine(4 % 2); // módulo

        // asignación --> operaciones de asignación (retorna valores numéricos)
        int num = 3;
        Console.WriteLine(num += 1); // num = num + 1
        Console.WriteLine(num -= 2); // num = num - 2
        Console.WriteLine(num *= 3); // num = num * 3
        Console.WriteLine(num /= 2); // num = num / 2

        // comparación --> operaciones para comparar operandos (retorna valores booleanos)
        Console.WriteLine(4 == 5); // son iguales?
        Console.WriteLine(4 < 3); // menor qué
        Console.WriteLine(4 <= 5); // menor o igual qué
        Console.WriteLine(3 > 4); // mayor qué
        Console.WriteLine(4 >= 2); // mayor o igual qué
        Console.WriteLine(4 != 3); // son diferentes?

        // lógicos --> operaciones lógicas (retorna valores booleanos)
        Console.WriteLine(3 > 2 && 2 < 3); // y, las dos tienen que ser verdaderas para retornar un verdadero
        Console.WriteLine(4 < 2 || 3 > 2); // o, si algunas de las dos es verdadera retorna verdadero sino falso
        Console.WriteLine(!(3 == 3)); // no, retorna el valor contrario del resultado
    }
}
