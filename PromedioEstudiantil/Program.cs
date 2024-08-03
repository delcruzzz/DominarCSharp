namespace PromedioEstudiantil;

public class Program
{
    public static void Main()
    {

    }

    public static char GetGrade(int s1, int s2, int s3)
    {
        var promedio = (s1 + s2 + s3) / 3;

        if (promedio >= 90 && promedio <= 100) return 'A';
        if (promedio >= 80 && promedio < 90) return 'B';
        if (promedio >= 70 && promedio < 80) return 'C';
        if (promedio >= 60 && promedio < 70) return 'D';
        
        return 'F';
    }
}
