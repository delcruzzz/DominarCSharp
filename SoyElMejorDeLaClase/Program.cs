namespace SoyElMejorDeLaClase;

public class Program
{
    public static void Main()
    {

    }

    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        double classAverage = 0;
        int sum = 0;

        for(int i = 0; i < ClassPoints.Length; i++)
        {
            sum += ClassPoints[i];
        }

        classAverage = sum / ClassPoints.Length;

        return classAverage > YourPoints ? false : true;
    }
}
