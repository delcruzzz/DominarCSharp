namespace Propiedades;

public class Program
{
    public static void Main()
    {
        // las propiedades

        /*
         las propiedades son las caracteristicas de las clases, donde se almacenan los valores para los 
         objetos, esta pueden o no estar protegidas (según se necesite) y se pueden usar las propiedades 
         para hacerlas visibles y ejercer cierto tipo de acción sobre ella, si son privadas 
         */

        Empleado empleado1 = new Empleado();

        Console.WriteLine(empleado1.Id);
        // empleado1.Id = 1; --> da error ya que solo podemos obtener su valor y no establecer un valor

        empleado1.Nombre = "Leonardo"; // podemos acceder para darle valor y para traer su valor
    }
}

public class Empleado
{
    private int _id; // propiedad privada
    private string _nombre = null!; // propiedad privada
    private string _document = null!; // propiedad privada

    public int Id // mascara pública de la propiedad original
    {
        get => _id; // a esta propiedad solo la podemos acceder
    }

    public string Nombre // mascara pública de la propiedad original
    {
        get => _nombre; // podemos acceder
        set => _nombre = value; // podemos darle valor
    }

    public string Document // mascara pública de la propiedad original
    {
        get => _document; // solo podemos acceder
    }

    /*
     los modificadores de acceso, nos permiten proteger nuestras clases, métodos, propiedades, etc. Lo cual 
     resulta conveniente para la seguridad en nuestro código, los tres más relevantes son:

     - public --> se puede acceder desde cualquier parte del código
     - protected --> solo se puede acceder desde la herencia
     - private --> no se puede acceder desde ninguna parte del código, ni en la herencia. Solo desde la misma clase de esa propiedad
     */
}
