# OneBillionRowChallenge

The challenge was based on an idea from this repository [The One Billion Row Challenge](https://github.com/gunnarmorling/1brc/tree/main).

The One Billion Row Challenge (1BRC) is a fun exploration of how far modern `C#`
can be pushed for aggregating one billion rows from a text file. 

The text file contains temperature values for a range of weather stations. Each
row is one measurement in the format `station name;measurement`,
with the measurement value having exactly one fractional digit. The following shows
ten rows as an example:

```
Bihac;-16,1
Jumla;-49,5
Montpellier;-64,1
Красноград;21,5
Расеиниаи;-62,8
Углегорск;-93,6
Suttsu;-60,5
...
```

The task is to write a C# program which reads the file, calculates the min, mean, and 
max temperature value per weather station, and emits the results on stdout like this 
(i.e. sorted alphabetically by station name, and the result values per station in the 
format , rounded to one fractional digit): `min/mean/max`.

`{Abha=-23.0/18.0/59.2, Bihac=-16.2/26.0/67.3, Красноград=-10.0/29.4/69.0, ...}`

## Supported versions of .NET

This software runs on .NET 8.0. The dotnet sdk 8.0.0 must be installed to work with the program.

## Autors

[Okolo IT](https://vk.com/okolo_it_govnokoding)

## License

>You can read the full license [here](https://github.com/SilverWolf2k20/OneBillionRowChallenge/blob/master/LICENSE.txt)
This project is under a **Unlicense** license.
