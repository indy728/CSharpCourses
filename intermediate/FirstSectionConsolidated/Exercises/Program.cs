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
                    if (stopwatch.GetRunning())
                        Console.WriteLine("Stopwatch has already been started!");
                    else
                        stopwatch.SetStart(); 
                }
                else if (input == "stop")
                {
                    if (!stopwatch.GetRunning())
                        Console.WriteLine("Stopwatch has not been started!");
                    else
                    {
                        stopwatch.SetStop();
                        var duration = stopwatch.Duration();
                        Console.WriteLine("Time of of this lap is {0} minutes and {1} seconds.", duration.Minutes, duration.Seconds);
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

            // var post = new StackOverflow();

            // post.Title = "How to properly use classes in C#";
            // post.Description = "Hi\n\nI'm new to OOP and would like to know if I'm doing this right. Do I totally suck?";
            
            // post.GetPostDetails();
            // Console.WriteLine("");

            // for (var i = 0; i < 69; i++)
            //     post.Upvote();

            // post.GetPostDetails();
            // Console.WriteLine("");

            // for (var i = 0; i < 27; i++)
            //     post.Downvote();

            // post.GetPostDetails();
            // Console.WriteLine("");
        }
    }
}
