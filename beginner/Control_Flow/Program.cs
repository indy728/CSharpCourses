using System;
using System.Linq;

namespace Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            // var season = Season.Summer;

            // switch (season)
            // {
            //     case Season.Fall:
            //     case Season.Summer:
            //         Console.WriteLine("We've got promotion.");
            //         break;
            //         // Console.WriteLine("It's a perfect time to go to the beach.");
            //         // break;
            //     case Season.Winter:
            //         Console.WriteLine("It's a great season for gathering with loved ones.");
            //         break;
            //     case Season.Spring:
            //         Console.WriteLine("It's the perfect time to enjoy the new flowers.");
            //         break;
            //     default:
            //         Console.WriteLine("That season doesn't make sense to me.");
            //         break;
            // }

            // #1
            // var num = Convert.ToInt32(Console.ReadLine());

            // var valid = (1 <= num && num <= 10) ? "Valid" : "Invalid";
            // Console.WriteLine(valid);

            // #2
            // var one = Convert.ToInt32(Console.ReadLine());
            // var two = Convert.ToInt32(Console.ReadLine());

            // var max = (one > two) ? one : two;
            // Console.WriteLine("The max of 2 inputs is {0}.", max);

            // #3
            // Console.WriteLine("Please enter the width of the picture:");
            // var width = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Please enter the height of the picture:");
            // var height = Convert.ToInt32(Console.ReadLine());

            // var orientation = (width > height) ? "landscape" : "portrait";
            // Console.WriteLine("The picture's orientation is {0}.", orientation);

            // #4
            // Console.Write("Please enter the speed limit for this area: ");
            // var speedLimit = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Please enter the speed the car was going: ");
            // var speed = Convert.ToInt32(Console.ReadLine());

            // int demerits = (speed - speedLimit) / 5;

            // if (demerits > 12)
            //         Console.WriteLine("License Suspended");
            // else if (demerits > 0)
            //         Console.WriteLine("Your reckless driving has earned you {0} demerits.", demerits);
            // else
            //         Console.WriteLine("Ok");

            // var name = "John Smith";

            // for (var i = 0; i < name.Length; i++)
            // {
            //     Console.WriteLine(name[i]);
            // }

            // This is the same.
            // foreach (var character in name)
            //     Console.WriteLine(character);

            // var numbers = new int[] {1, 2, 3, 4};

            // foreach(var number in numbers)
            //     Console.WriteLine(number);

            // var random = new Random();

            // const int passwordLength = 12;
            // var buffer = new char[passwordLength];
            // for (var i = 0; i < passwordLength; i++)
            //     buffer[i] = ((char)random.Next('a', 'z'));
            // var password = new string(buffer);

            // Console.WriteLine(password);

            // #1
            // int count = 0;

            // for (var i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0)
            //         count++;
            // }
            // Console.WriteLine(count);

            // #2
            // int sum = 0;
            // string current;

            // while (true)
            // {
            //     Console.Write("Please enter a number or 'ok' to exit: ");
            //     current = Console.ReadLine();

            //     if (current == "ok")
            //         break;
            //     else
            //         sum += Convert.ToInt32(current);
            // }
            // Console.WriteLine(sum);

            // #3
            // Console.Write("Please enter a positive number: ");
            // var factorial = Convert.ToInt32(Console.ReadLine());
            // int dec = factorial;
            // while (--dec > 1)
            //     factorial *= dec;
            // Console.WriteLine("5! = {0}.", factorial);

            // #4
            // var random = new Random();
            // int rand = random.Next(1, 10);
            // int i = 0;
            // int guess;

            // while(i++ < 4)
            // {
            //     Console.Write("Guess a number between 1 and 10: ");
                
            //     guess = Convert.ToInt32(Console.ReadLine());

            //     if (guess == rand)
            //     {
            //         Console.WriteLine("You won!");
            //         break;
            //     }
            //     else
            //         Console.WriteLine("You lost!");
            // }
            // if (i >= 4)
            //     Console.WriteLine("4 tries; you suck.");

            // #5
            Console.Write("Please enter a series of numbers separated by a comma and a space: ");
            string input = Console.ReadLine();
            input = input.Replace(" ", "");

            int[] nums;

            nums = Array.ConvertAll(input.Split(','), int.Parse);
            Console.WriteLine(nums.Max());
        }
    }
}
