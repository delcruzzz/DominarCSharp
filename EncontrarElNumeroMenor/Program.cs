namespace EncontrarElNumeroMenor;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(FindSmallestInt(new int[] { 1, 4, -90, 2, -990, 19 }));
    }

    public static int FindSmallestInt(int[] args)
    {
        return args.Min();
    }
}
