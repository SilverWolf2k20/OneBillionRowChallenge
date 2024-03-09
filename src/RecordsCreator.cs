namespace OneBillionRowChallenge;

internal static class RecordsCreator
{
    public static void Create(string path, int count)
    {
        string[] rows = File.ReadAllLines(@"..\..\..\..\res\weather_stations.txt");

        Random rand = new();
        using StreamWriter stream = new(path);

        for (var i = 0; i < count; i++)
            stream.WriteLine($"{rows[rand.Next(0, rows.Length - 1)]};{Math.Round(-97.9 + rand.NextDouble() * (56.6 + 97.9), 1)}");

        Console.WriteLine("Created!");
    }
}
