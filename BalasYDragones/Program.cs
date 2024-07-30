namespace BalasYDragones;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Hero(500, 5));
    }

    public static bool Hero(int bullets, int dragons)
    {
        if (bullets / 2 == dragons || bullets / 2 > dragons)
        {
            return true;
        }

        return false;
    }
}
