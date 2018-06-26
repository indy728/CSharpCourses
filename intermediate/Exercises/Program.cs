using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                Console.WriteLine("Please enter a stopwatch command ('start' 'stop' 'exit'): ");
                var input = Console.ReadLine();

                if (input == "start")
                {
                    if (DateTime.Compare(stopwatch.GetStart(), new DateTime()) != 0)
                        Console.WriteLine("Stopwatch has already been started!");
                    else
                        stopwatch.SetStart(); 
                }
                else if (input == "stop")
                {
                    if (DateTime.Compare(stopwatch.GetStart(), new DateTime()) == 0)
                        Console.WriteLine("Stopwatch has not been started!");
                    else
                    {
                        stopwatch.SetStop();
                        var duration = stopwatch.Duration;
                        Console.WriteLine("Time of of this lap is {0} minutes and {1} seconds.", duration.Minutes, duration.Seconds);
                        stopwatch.Reset();
                    }
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Goodbye");
                    break ;
                }
                else
                    Console.WriteLine("Invalid input, try again.");
            }
        }
    }
}
