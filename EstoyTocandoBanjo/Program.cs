namespace EtoyTocandoBanjo;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(AreYouPlayingBanjo("Ronald"));
    }

    public static string AreYouPlayingBanjo(string name)
    {
        if (name.StartsWith("R") || name.StartsWith("r"))
        {
            return name + " plays banjo";
        }

        return name + " does not playing banjo";
    }
}
