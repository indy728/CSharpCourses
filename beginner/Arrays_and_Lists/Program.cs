using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAYS: PROPERTIES AND METHODS
            // var numbers = new[] {3, 7, 9, 2, 14, 6 };
            // var numbers2 = new int[3];

            // Length
            // Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()
            // var index = Array.IndexOf(numbers, 9);
            // Console.WriteLine("Index of 9: " + index);

            // Clear()
            // Array.Clear(numbers, 0, 2);

            // foreach (var number in numbers)
            //     Console.WriteLine("{0} ", number);

            // Copy()
            // Array.Copy(numbers, numbers2, 3);

            // foreach (var number in numbers2)
            //     Console.WriteLine("{0} ", number);

            // Sort() & Reverse()
            // Array.Sort(numbers);
            // foreach (var number in numbers)
            //     Console.WriteLine("{0} ", number);

            // Array.Reverse(numbers);
            // foreach (var number in numbers)
            //     Console.WriteLine("{0} ", number);


            // LISTS: PROPERTIES AND METHODS
            // using System.Collections.Generic;   

            // var numbers = new List<int>() {1, 2, 3, 4};
            // numbers.Add(1);
            // numbers.AddRange(new int[3] {6, 7, 8});

            // foreach (var number in numbers)
            //     Console.WriteLine(number);

            // IndexOf() (first instance of item)
            // Console.WriteLine("Index of 99: " + numbers.IndexOf(99));
            // Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // Count
            // Console.WriteLine("Count: " + numbers.Count);

            // Remove()
            // numbers.Remove(1);
            // for (var  i = 0; i < numbers.Count; i++)
            // {
            //     if (numbers[i] == 1)
            //         numbers.Remove(numbers[i]);
            //     // else
            //     // Console.WriteLine(number);
            // }
            // foreach (var number in numbers)
            //     Console.WriteLine(number);

            // Clear()
            // numbers.Clear();
            // Console.WriteLine("Count: " + numbers.Count);

            // #1
            // var friends = new List<string>();
            // string friend;
            // Console.WriteLine("Enter friends names who like your post: ");
            // while (true)
            // {
            //     friend = Console.ReadLine();
            //     if (String.IsNullOrWhiteSpace(friend))
            //         break;
            //     friends.Add(friend);
            // }
            // var friendCount = friends.Count;

            // if (friendCount > 2)
            //     Console.WriteLine("{0}, {1} and {2} others like your post.", friends[0], friends[1], friendCount - 2);
            // else if (friendCount == 2)
            //     Console.WriteLine("{0} and {1} like your post.", friends[0], friends[1]);
            // else if (friendCount == 1)
            //     Console.WriteLine("{0} likes your post.", friends[0]);

            // #2
            // Console.WriteLine("Please write your name: ");
            // string homie = Console.ReadLine();
            // var homieLength = homie.Length;
            // var holdingArray = new char[homieLength];
            // for (var i = 0; i < homieLength; i++)
            //     holdingArray[i] = homie[i];
            // Array.Reverse(holdingArray);
            // string reverseHomie = String.Join("", holdingArray);
            // Console.WriteLine(reverseHomie);

            // #3
            // var numbers = new List<int>();
            // int thisNumber;
            // int index;
            // Console.WriteLine("Please enter 5 unique numbers: ");
            // while (true)
            // {
            //     if (numbers.Count == 5)
            //         break;
            //     thisNumber = Convert.ToInt32(Console.ReadLine());
            //     index = numbers.IndexOf(thisNumber);
            //     if (index == -1)
            //         numbers.Add(thisNumber);
            //     else
            //     {
            //         Console.WriteLine("You have already entered this number! Please enter 5 unique numebrs: ");
            //         numbers.Clear();
            //     }
            // }
            // numbers.Sort();
            // foreach (var number in numbers)
            //     Console.Write(number + " ");
            // Console.WriteLine("");

            // #4
            // var numbers = new List<int>();
            // string thisEntry;
            // int thisNumber;
            // int index;
            // Console.WriteLine("Please enter as many numbers as you want: ");
            // while (true)
            // {
            //     thisEntry = Console.ReadLine();
            //     if (thisEntry == "Quit")
            //         break;
            //     thisNumber = Convert.ToInt32(thisEntry);
            //     index = numbers.IndexOf(thisNumber);
            //     if (index == -1)
            //         numbers.Add(thisNumber);
            // }
            // // numbers.Sort();
            // foreach (var number in numbers)
            //     Console.Write(number + " ");
            // Console.WriteLine("");

            // #5
            string input;
            int[] nums;
            int count;
            var numbers = new List<int>();
            while (true)
            {
                Console.Write("Please enter a series of numbers separated by a comma and a space: ");
                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                input = input.Replace(" ", "");
                nums = Array.ConvertAll(input.Split(','), int.Parse);
                numbers = new List<int>(nums);
                count = numbers.Count;
                if (count < 5)
                {
                    numbers.Clear();
                    Console.WriteLine("Invalid List");
                }
                else
                    break;
            }
            numbers.Sort();
            for (var i = 0; i < 3; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
