namespace TomaDeDecisiones;

public class Program
{
    public static void Main()
    {
        // toma de decisiones

        /*
         esto nos ayuda para tener un control sobre el flujo de nuestro código, para controlar 
         que si cierto/s datos no pasan cierta condición no hagan cierta acción, así podremos 
         ejercer control sobre el código.

         if, significa que pasa si
         else if, si if no se cumple son otras posibles condiciones para cumplir
         else, si ninguna condición se cumple se ejecuta esta por defecto
         */

        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        if (edad >= 18)
        {
            Console.WriteLine("Puedes seguir");
        }
        else
        {
            Console.WriteLine("No puedes seguir, eres menor de edad");
        }

        // ó

        if (edad >= 0 && edad < 12)
        {
            Console.WriteLine("Eres un niño");
        }
        else if (edad >= 12 && edad < 18)
        {
            Console.WriteLine("Eres adolescente");
        }
        else if (edad >= 18 && edad < 60)
        {
            Console.WriteLine("Eres un adulto");
        }
        else
        {
            Console.WriteLine("Eres un adulto mayor");
        }
    }
}
