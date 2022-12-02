internal class Program
{
    private static void Main(string[] args)
    {
        int i = 100;
        // i = null;// i kann nicht null sein 
        int? j = null; // "noch" kein Wert zugewiesen

        Console.WriteLine(j);

        j = 200;

        Console.WriteLine(j);

        if (j.HasValue) // ungleich null
        {
            i = i * j.Value;
        }

        int k = i * j.GetValueOrDefault();

        double? v = null;

        string? s = null;

        string text = null;
    }
}