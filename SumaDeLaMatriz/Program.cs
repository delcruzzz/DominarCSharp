namespace SumaDeLaMatriz;

public class Program
{
    public static void Main()
    {
        int[] ints = { 1, 2, 3, 4, 5 };
        Console.WriteLine(ints.Sum());
    }

    public static double SumArray(double[] array)
    {
        if (array.Length == 0) return 0;

        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum;
    }
}
