namespace SobrescrituraDeMetodos;

public class Program
{
    public static void Main()
    {
        // sobrescritura de métodos

        /*
         es una tecnica que permite a una clase derivada o hija proporcionar una implementación específica de un método 
         que ya está definio en su clase base o padre. Este mecanismo es fundamental para el polimorfismo y POO, ya 
         que permite a los objetos de diferentes tipos responder a la misma llamada de método de maneras diferente.

         Para sobrescribir el método se debe cumplir:

         - el método de la clase debe ser abstracto o virtual, esto indica que el método puede ser sobrescrito en una clase derivada
         - las clase derivada usa la palabra clave override para redefinir el método
         */

        Animal animal1 = new Animal();
        animal1.HacerSonido(); // el animal hace un sonido

        Dog perro1 = new Dog();
        perro1.HacerSonido(); // el perro ladra
    }
}

public class Animal
{
    // método virtual que puede ser sobrescrito en una clase derivada
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

public class Dog : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine($"El perro ladra");
    }
}
