namespace Estructurados;

public class Program
{
    public static void Main()
    {
        // los structs

        /*
         es un tipo de dato que puede contener varios miembros, como campos y métodos. A diferencia de las clases, los structs 
         son tipos de valor y se almacenan directamente en la pila en lugar de en el heap. Esto significa que son más eficientes 
         en terminos de memoria y rendimiento cuando se usan para almacenar datos pequeños y simples.

         caracteristicas:

         - los structs son tipos de valor, lo que significa que cuando se asignan a una nueva variable, se copia el valor completo 
           en lugar de una referencia.
         - estos se destruyen automáticamente al salir de su ámbito.
         - aunque los structs no tienen que ser inmutables, a menudo se diseñan como tales para evitar problemas con la copia de valores.
         - los structs no pueden heredar de otros structs o clases, ni pueden ser base de otros structs o clases. Sin embargo, pueden 
           implementar interfaces
         - no se pueden definir constructores sin parámetros en un struct. Sin embargo el compilador proporciona un constructor ímplicito 
           que inicializa los campos con sus valores predeterminados.
         */

        Punto p1 = new Punto(2, 3);
        Punto p2 = new Punto(5, 7);

        double distancia = p1.Distancia(p2);
        Console.WriteLine($"Distancia entre p1 y p2: {distancia}");
    }
}

public struct Punto
{
    public int X { get; }
    public int Y { get; }

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distancia(Punto otroPunto)
    {
        int dx = X - otroPunto.X;
        int dy = Y - otroPunto.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
}