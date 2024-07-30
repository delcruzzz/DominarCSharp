namespace ConversionesExplicitasEImplicitas;

public class Program
{
    public static void Main()
    {
        double miNumeroDoble = 34.99;
        int nuevoEntero = (int)miNumeroDoble; // conversión explícita
        Console.WriteLine(nuevoEntero);

        int miNumero = 12345;
        long nuevoNumero = miNumero; // conversión implícita
        Console.WriteLine(nuevoNumero);

        // conversión de números a texto
        Console.WriteLine(nuevoNumero.ToString());

        string numero = "300";
        int numeroEntero = int.Parse(numero); // parseo de string a número entero
        Console.WriteLine(numeroEntero);
    }
}
