#define CREATE
#define ATTEMPT_1

using System.Diagnostics;

using OneBillionRowChallenge;

#if CREATE

RecordsCreator.Create(@"..\..\..\..\res\records_1B.txt", 10_000_000);

#endif

#if ATTEMPT_1 // 475 697 ms

Stopwatch stopwatch = Stopwatch.StartNew();
SimpleAnalyzer.Analyze(@"..\..\..\..\res\records_1B.txt");
stopwatch.Stop();
Console.WriteLine($"Total time: {stopwatch.ElapsedMilliseconds}ms");

#endif

// mean = (max + min) / 2

// Output:
// A = -10.0/10.0/30.0
// B = -10.0/10.0/30.0
