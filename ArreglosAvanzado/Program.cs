// arreglos

/*
 es una estructura de datos que permite almacenar una colección de datos del mismo tipo en una única 
 variable.

 Estos elementos están rdenados en posiciones consecutivas de memoria, y cada uno de ellos puede ser 
 accedido a través de un índice que representa su posición en el arreglo, desde la posición 0 hasta la 
 posición n.
 */

int[] numeros = new int[5]; // se crea un arreglo de 5 elementos de tipo entero
string[] nombres = { "leonardo", "jose", "claudia" }; // se crea un arreglo de 3 elementos de tipo string y se inicializa con valores

numeros[0] = 1; // agregando valores a los elementos del arreglo
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;

Console.WriteLine(numeros[0]); // accediendo a los elementos del arreglo

numeros[4] = 10; // modificando el valor de un elemento del arreglo
Console.WriteLine(numeros[4]); // accediendo al elemento modificado

for(int i = 0; i < nombres.Length; i++) // recorriendo el arreglo de nombres
{
    Console.WriteLine(nombres[i]);
}

foreach(string nombre in nombres) // recorriendo el arreglo de nombres con foreach
{
    Console.WriteLine(nombre);
}

// usando la clase Array

Array.ForEach(numeros, num => Console.WriteLine(num)); // recorriendo el arreglo de numeros con Array.ForEach

Console.WriteLine(numeros.Length); // propiedad que devuelve la cantidad de elementos del arreglo

Array.Sort(numeros); // ordenando el arreglo de numeros
Array.ForEach(numeros, num => Console.WriteLine(num));

Array.Reverse(numeros); // invirtiendo el orden del arreglo de numeros
Array.ForEach(numeros, num => Console.WriteLine(num));

Array.IndexOf(numeros, 3); // buscando un elemento en el arreglo de numeros, si lo encuentra devuelve el indice, si no devuelve -1

Array.Find(numeros, num => num > 3); // buscando un elemento en el arreglo de numeros, si lo encuentra devuelve el elemento, si no devuelve 0

Array.Exists(numeros, num => num > 3); // buscando un elemento en el arreglo de numeros, si lo encuentra devuelve true, si no devuelve false

Array.Resize(ref numeros, 10); // redimensionando el arreglo de numeros
Console.WriteLine(numeros.Length);

Array.Clear(numeros, 0, numeros.Length); // limpiando el arreglo de numeros
Array.ForEach(numeros, num => Console.WriteLine(num));

// arreglos multidimensionales

int[,] matriz = new int[3, 3]; // se crea una matriz de 3x3
matriz[0, 0] = 1; // agregando valores a los elementos de la matriz
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 4;
matriz[1, 1] = 5;
matriz[1, 2] = 6;
matriz[2, 0] = 7;
matriz[2, 1] = 8;
matriz[2, 2] = 9;
matriz[3, 0] = 10; // error, el indice esta fuera de rango

// Console.WriteLine(matriz[0, 0]); // accediendo a los elementos de la matriz

for(int i = 0; i < 3; i++) // recorriendo la matriz
{
    for(int j = 0; j < 3; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
