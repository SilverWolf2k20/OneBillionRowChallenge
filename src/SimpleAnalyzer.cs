namespace OneBillionRowChallenge;

file class Data
{
    internal double Min { get; set; }
    internal double Max { get; set; }
    public override string ToString()
    {
        double mean = (Min + Max) / 2.0;
        return $"{Math.Round(Min, 2, MidpointRounding.AwayFromZero)} / {Math.Round(mean, 2, MidpointRounding.AwayFromZero)} / {Math.Round(Max, 2, MidpointRounding.AwayFromZero)}";
    }
}

internal static class SimpleAnalyzer
{
    internal static void Analyze(string path)
    {
        Dictionary<string, Data> stations = [];
        string? line;

        // Read
        using var reader = File.OpenText(path);
        while ((line = reader.ReadLine()) is not null) {
            string[] datas = line.Split(';');

            string stationName = datas[0];
            double value = double.Parse(datas[1]);

            if (stations.ContainsKey(datas.First()) == false)
                stations.Add(stationName, new Data());

            stations[datas.First()].Min = Math.Min(stations[datas.First()].Min, value);
            stations[datas.First()].Max = Math.Max(stations[datas.First()].Max, value);
        }

        // Write
        stations.OrderBy(s => s.Key)
            .ToList()
            .ForEach(s => Console.WriteLine($"{s.Key} = {s.Value}"));
    }
}
