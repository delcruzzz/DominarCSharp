// conjuntos

/*
 un conjunto es una colección de elementos que no se repiten y no tienen un orden definido. En C#, los conjuntos 
 se implementan con la clase HashSet<T> del espacio de nombres System.Collections.Generic, donde T es el tipo de
 elementos que se almacenarán en el conjunto. 
 */

HashSet<int> conjunto = new HashSet<int>();

conjunto.Add(1);
conjunto.Add(2);
conjunto.Add(3);
conjunto.Add(4);
conjunto.Add(5);

conjunto.Add(1); // no se agrega porque ya existe

foreach (int i in conjunto)
{
    Console.WriteLine(i); // 1... n
}


// comprobar si un conjunto contiene un elemento
if (conjunto.Contains(3))
{
    Console.WriteLine("El conjunto contiene el número 3");
}
else
{
    Console.WriteLine("El conjunto no contiene el número 3");
}

// eliminar un elemento del conjunto
conjunto.Remove(3);

// comprobar si un conjunto está vacío
if (conjunto.Count == 0)
{
    Console.WriteLine("El conjunto está vacío");
}
else
{
    Console.WriteLine("El conjunto no está vacío");
}

// vaciar un conjunto
conjunto.Clear();

// operaciones con conjuntos
HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };

// unión
HashSet<int> union = new HashSet<int>(conjunto1);
union.UnionWith(conjunto2);

// intersección
HashSet<int> interseccion = new HashSet<int>(conjunto1);
interseccion.IntersectWith(conjunto2);

// diferencia
HashSet<int> diferencia = new HashSet<int>(conjunto1);
diferencia.ExceptWith(conjunto2);

// diferencia simétrica
HashSet<int> diferenciaSimetrica = new HashSet<int>(conjunto1);
diferenciaSimetrica.SymmetricExceptWith(conjunto2);

// comprobar si un conjunto es subconjunto de otro, todos los elementos del conjunto 1 están en el conjunto 2
if (conjunto1.IsSubsetOf(conjunto2))
{
    Console.WriteLine("El conjunto 1 es subconjunto del conjunto 2");
}
else
{
    Console.WriteLine("El conjunto 1 no es subconjunto del conjunto 2");
}
