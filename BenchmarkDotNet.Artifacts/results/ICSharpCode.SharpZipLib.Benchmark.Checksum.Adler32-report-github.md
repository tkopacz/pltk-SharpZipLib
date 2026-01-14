```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7623/25H2/2025Update/HudsonValley2)
13th Gen Intel Core i7-13800H 2.50GHz, 1 CPU, 20 logical and 14 physical cores
.NET SDK 10.0.102
  [Host]     : .NET 6.0.36 (6.0.36, 6.0.3624.51421), X64 RyuJIT x86-64-v3
  Job-KPDMSS : .NET 6.0.36 (6.0.36, 6.0.3624.51421), X64 RyuJIT x86-64-v3

Toolchain=.NET 6.0  

```
| Method             | Mean     | Error   | StdDev  | Ratio | RatioSD |
|------------------- |---------:|--------:|--------:|------:|--------:|
| Adler32LargeUpdate | 134.1 ms | 2.61 ms | 2.80 ms |  1.00 |    0.03 |
