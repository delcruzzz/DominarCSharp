// diccionarios

/*
 es una colección de pares clave-valor, donde cada clave es única y se asocia con un único valor. En C#, los 
 diccionarios se implementan mediante la clase Dictionary<TKey, TValue> del espacio de nombres System.Collections.Generic, 
 donde TKey es el tipo de la clave y TValue es el tipo del valor. 
 */

Dictionary<string, int> edades = new Dictionary<string, int>(); // Crea un diccionario vacío

edades.Add("Juan", 25); // Añade un nuevo par clave-valor
edades.Add("María", 30);
edades.Add("Carlos", 40);

Console.WriteLine(edades["Juan"]); // 25, accede al valor asociado a la clave "Juan"

edades["Juan"] = 26; // Modifica el valor asociado a la clave "Juan"

edades.Remove("María"); // Elimina el par clave-valor con clave "María"

foreach (var kvp in edades)
{
    Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
}

// Clave: Juan, Valor: 26
// Clave: Carlos, Valor: 40

// Comprobar si una clave existe en el diccionario
if (edades.ContainsKey("Juan"))
{
    Console.WriteLine("La clave 'Juan' existe en el diccionario");
}

// Comprobar si un valor existe en el diccionario
if (edades.ContainsValue(26))
{
    Console.WriteLine("El valor 26 existe en el diccionario");
}

// Vaciar el diccionario
edades.Clear();

// Comprobar si el diccionario está vacío
if (edades.Count == 0)
{
    Console.WriteLine("El diccionario está vacío");
}

// Diccionarios con tipos de clave y valor diferentes
Dictionary<int, string> colores = new Dictionary<int, string>
{
    { 1, "Rojo" },
    { 2, "Verde" },
    { 3, "Azul" }
};

foreach (var kvp in colores)
{
    Console.WriteLine($"Clave: {kvp.Key}, Valor: {kvp.Value}");
}
