// listas

/*
 es una estructura de datos que permite almacenar una colección de elementos del mismo tipo de forma secuencial.
 A diferencia de los arreglos, las listas no tienen un tamaño fijo, por lo que pueden crecer o reducirse en tiempo de ejecución 
 o de forma dinámica.

 Además las listas proporcionan métodos para insertar, eliminar, buscar y ordenar elementos de forma sencilla.

 lista es un genérico, es decir, se puede especificar el tipo de elementos que va a almacenar.
 */

List<string> nombres = new List<string>();

nombres.Add("Juan"); // agrega un elemento al final de la lista
nombres.Add("Maria");
nombres.Add("Pedro");

nombres.Insert(1, "Luis"); // inserta un elemento en la posición indicada

nombres.Remove("Maria"); // elimina la primera aparición del elemento indicado

nombres.RemoveAt(0); // elimina el elemento en la posición indicada

nombres.Sort(); // ordena los elementos de la lista

foreach (string nombre in nombres) // recorre la lista
{
    Console.WriteLine(nombre);
}

List<int> enteros = new List<int> { 1, 2, 3, 4, 5 }; // inicializa la lista con los elementos indicados

int suma = enteros.Sum(); // suma los elementos de la lista
Console.WriteLine(suma);

int maximo = enteros.Max(); // obtiene el elemento mayor de la lista
Console.WriteLine(maximo);

int minimo = enteros.Min(); // obtiene el elemento menor de la lista
Console.WriteLine(minimo);

int promedio = (int)enteros.Average(); // obtiene el promedio de los elementos de la lista
Console.WriteLine(promedio);

int cantidad = enteros.Count(); // obtiene la cantidad de elementos de la lista
Console.WriteLine(cantidad);

bool contiene = enteros.Contains(3); // verifica si la lista contiene el elemento indicado
Console.WriteLine(contiene);

int indice = enteros.IndexOf(3); // obtiene el índice de la primera aparición del elemento indicado
Console.WriteLine(indice);

enteros.Clear(); // elimina todos los elementos de la lista
