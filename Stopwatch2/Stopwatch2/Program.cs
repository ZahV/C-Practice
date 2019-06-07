using System;
using System.Runtime.InteropServices;

namespace Stopwatch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch2 stopwatch = new Stopwatch2();
            while (true)
            {
                if (stopwatch.IsPaused())
                {
                    Console.WriteLine("Stopwatch is paused");
                }
                else
                {
                    Console.WriteLine($"Current time is {stopwatch.CurrentTime.TotalSeconds}");
                }

                Console.WriteLine("Type 'S' to start and 'T' to stop or 'P' to pause the stopwatch and 'Q' to quit.");
                string input = Console.ReadLine().ToLower();
                bool shouldQuit = false;

                switch (input)
                {
                    case "s":
                    case "start":
                        stopwatch.Start();
                        break;
                    case "p":
                    case "pause":
                        stopwatch.Pause();
                        break;
                    case "t":
                    case "stop":
                        Console.WriteLine($"{stopwatch.Stop().TotalSeconds} seconds have elapsed");
                        break;
                    case "q":
                    case "quit":
                        shouldQuit = true;
                        break;
                    case "c":
                    case "continue":
                        break;
                    default:
                        goto case "c";
                }

                if (shouldQuit)
                {
                    break;
                }
            }
        }
    }
}