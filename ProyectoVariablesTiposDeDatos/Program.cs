namespace ProyectoVariablesTiposDeDatos;

public class Program
{
    public static void Main()
    {
        // creación de una variable -> inicializada o declarada
        int numPrueba = 9; // inicializada
        Console.WriteLine(numPrueba);
        int numPruebaDeclarada; // solo declarada
        numPruebaDeclarada = 0;
        Console.WriteLine(numPruebaDeclarada);

        // tipos de datos

        /*
         int -> número entero = 8, -23, 88999
         float -> número con punto decimal = 4.56f, -234.56333f *precisión de siete digitos*
         double -> número con punto decimal = 56.3, -332.5 *precisión de quince digitos*
         decimal -> número con punto decimal = 4.77m, 6.990m, -445.22m *precisión de veinte ocho digitos*
         bool -> solo valor true o false
         string -> cadena de caracteres, se usa con comillas dobles = "Leonardo", "Hola Mundo"
         char -> un solo caracter, se usa con comillas simples = '$', 'a'
         */

        int miVariableEntera = 5;
        float miVariableFlotante = -445.7f;
        double miVariableDoble = 4.55;
        decimal miVariableDecimal = 400.3m;
        bool miVariableBooleana = false;
        string miVariableCadenaDeTexto = "Hola Mundo";
        char miVariableCaracter = 'A';

        Console.WriteLine(miVariableEntera);
        Console.WriteLine(miVariableFlotante);
        Console.WriteLine(miVariableDoble);
        Console.WriteLine(miVariableDecimal);
        Console.WriteLine(miVariableBooleana);
        Console.WriteLine(miVariableCadenaDeTexto);
        Console.WriteLine(miVariableCaracter);

        // string y sus métodos
        string nombre = "Leonardo";
        Console.WriteLine(nombre);

        // -- acceso a las cadenas de texto
        // ---- accedemos por medio de posiciones, desde la posición 0 hasta la posición n
        Console.WriteLine(nombre[0]); // accedemos a la primera posición
        Console.WriteLine(nombre[4]); // accedemos a la cuarta posición (realmente quinta)
        Console.WriteLine(nombre[nombre.Length - 1]); // accedemos a la última posición


        // -- concatenación de strings o interpolación
        Console.WriteLine($"Mi nombre es {nombre}");

        // -- métodos
        Console.WriteLine(nombre.ToUpper()); // nos retorna una copia de la variable con su valor en mayúsculas
        Console.WriteLine(nombre.ToLower()); // nos retorna una copia de la variable con su valor en minúsculas
        Console.WriteLine(nombre.Trim()); // nos retorna una copia de la variable sin espacios en blanco a ninguno de sus lados
        Console.WriteLine(nombre.Substring(1, 4)); // nos retorna una copia de la variable cortada por medio de las posiciones restandole -1 a la última posición indicada
        Console.WriteLine(nombre.Replace('L', 'l')); // nos retorna una copia de la variable con los valores reemplazados por el que se indicó
        Console.WriteLine(nombre.IndexOf('e')); // busca la primera aparición y retorna su posición

        // -- propiedades
        Console.WriteLine(nombre.Length); // nos retorna la longitud de la cadena de texto

        // -- métodos de la clase Console
        Console.Write("Hello"); // imprime por consola y el WriteLine hace lo mismo pero le añade un salto de línea al final
        Console.Read(); // nos permite ingresar un dato por la consola, todo lo que se ingresa es recibido como string
        Console.ReadLine(); // nos permite ingresar un dato por la consola y nos lo retorna
    }
}
