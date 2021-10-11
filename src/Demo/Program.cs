// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Fibonacci;

class Program
{
    
    public static async Task Main(string[] args)
    {
        Stopwatch stopwatch = new();
        stopwatch.Start();

        using var fibonacciDataContext = new FibonacciDataContext();

        var tasks = await new Fibonacci.Compute(fibonacciDataContext).ExecuteAsync(args);

        foreach (var task in tasks) Console.WriteLine($"Fibo result: {task}");
        stopwatch.Stop();
        Console.WriteLine($"{stopwatch.Elapsed.Seconds} s");

    }
}