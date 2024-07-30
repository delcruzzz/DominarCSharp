namespace ConvertirANegativo;

public class Program
{
    public static void Main()
    {

    }

    public static int MakeNegative(int number)
    {
        if (number < 0)
        {
            return number;
        }
        else if (number > 0)
        {
            return number * -1;
        }

        return 0;
    }
}
