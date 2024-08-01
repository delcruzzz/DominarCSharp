namespace Polimorfismo;

public class Program
{
    public static void Main()
    {
        // el polimorfismo

        /*
         permite que un objeto de una clase pueda ser tratado como una clase base o una interfaz que esa clase se implemente. 
         Esto proporciona flexibilidad y reutilización del código, permitiendo que una sola interfaz pueda servir para un 
         conjunto de clases.
         */

        // polimorfismo con clases
        Animal perro = new Perro();
        perro.Raza = "Labrador";
        perro.Name = "Lucas";

        perro.HacerSonido();

        // polimorfismo con interfazes
        ITransporte carro = new Coche();
        carro.Mover();
    }
}

// polimorfismo con clases
public class Animal
{
    public string Raza { get; set; } = null!;
    public string Name { get; set; } = null!;

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra.");
    }
}

// polimorfismo con interfazes
public interface ITransporte
{
    void Mover();
}

public class Coche : ITransporte
{
    public void Mover()
    {
        Console.WriteLine("El coche se mueve.");
    }
}
