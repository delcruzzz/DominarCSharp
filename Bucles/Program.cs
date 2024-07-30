namespace Bucles;

public class Program
{
    public static void Main()
    {
        // bucles

        UsoDeWhile(); // bucle while
        UsoDelFor(); // bucle for
        UsoDelDoWhile(); // bucle do... while

        /*
         el break nos sirve para parar el bucle cuando se cumple una condición específica 
         dentro de este y se llama a esta palabra.

         el continue nos sirve para saltarnos cierta parte si se cumple una condición específica
         dentro del bucle.
         */

        UsoDelBreakYContinue();
    }

    public static void UsoDeWhile()
    {
        /*
         es un bucle que nos sirve para ejecutar cierta parte del código mientras esta sea 
         verdadera. Si la condición es falsa, el ciclo termina (si la condición desde el 
         principio es falsa, nunca se ejecuta)
         */

        int num = 0;

        while (num <= 10)
        {
            num++;
            Console.WriteLine(num);
        }
    }

    public static void UsoDelFor()
    {
        /*
         es una estructura de control que se utiliza para iterar una secuencia de instrucciones de forma repetitiva.
         Permite especificar una expresión de inicialización, una condición de continuación y una expresión de iteración
         */

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void UsoDelDoWhile()
    {
        /*
         permite ejecutar repetidamente un bloqu de código mientras se cumple una condición, pero a diferencia del while, 
         el bloque de código se ejecuta al menos una vez antes de comprobar la condición
         */

        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 10);
    }

    public static void UsoDelBreakYContinue()
    {
        // break
        int i = 0;
        while (i <= 10)
        {
            i++;

            if (i == 2)
            {
                Console.WriteLine($"Uso del break {i}");
                break;
            }

            Console.WriteLine(i);
        }

        // continue
        int x = 0;
        while (x <= 10)
        {
            x++;

            if (x == 2)
            {
                continue;
            }

            Console.WriteLine($"Uso del continue {x}");
        }
    }
}
