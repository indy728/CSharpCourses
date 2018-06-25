using System;
using System.Text;
using System.Collections.Generic;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // var fullname = "Kyle Murray ";
            // Console.WriteLine("Trim: '{0}'", fullname.Trim());
            // Console.WriteLine("ToUpper: '{0}'", fullname.ToUpper());

            // var index = fullname.IndexOf(' ');
            // var firstName = fullname.Substring(0, index);
            // var lastName = fullname.Substring(index + 1);
            // Console.WriteLine("{0}:{1}", firstName, lastName.Trim());

            // var names = fullname.Split(' ');
            // Console.WriteLine("{0}:{1}", names[0], names[1]);

            // var newName = fullname.Replace("Kyle", "Lexi");
            // Console.WriteLine(newName.Trim());

            // if (String.IsNullOrEmpty(null))
            //     Console.WriteLine("Invalid");
            // if (String.IsNullOrEmpty(""))
            //     Console.WriteLine("Invalid");
            // if (String.IsNullOrWhiteSpace(" "))
            //     Console.WriteLine("Invalid");

            // var stringInput = "25";
            // var age = Convert.ToByte(stringInput);
            // Console.WriteLine(age);

            // float price = 29.95f;
            // var priceString = price.ToString("C");
            // Console.WriteLine(priceString);

            // SUMMARIZING TEXT
            // var sentence = "Velit eiusmod qui ut do est anim Lorem ex nulla elit reprehenderit aute proident. Fugiat reprehenderit nisi duis nulla elit sit nulla consequat do. Consectetur occaecat velit consequat dolore consequat cupidatat eu culpa. Enim excepteur ex amet ut ullamco velit ipsum tempor. Ex eu consectetur officia ex cillum consequat. Proident sint cupidatat adipisicing aliqua labore anim cupidatat. Consequat anim pariatur incididunt dolor aliquip occaecat.";

            // var summary = StringUtility.SummarizeText(sentence, 50);
            // Console.WriteLine(summary);

            // var builder = new StringBuilder();
            // builder.Append('-', 10);
            // builder.AppendLine();
            // builder.Append("Header");
            // builder.AppendLine();
            // builder.Append('-', 10);
            
            // builder.Append('-', 10)
            //     .AppendLine()
            //     .Append("Header")
            //     .AppendLine()
            //     .Append('-', 10);

            // builder.Replace('-', '+');
            // builder.Remove(0, 10);

            // builder.Insert(0, new string('-', 10));
            // Console.WriteLine(builder);

            // Console.WriteLine("First Character: " + builder[0]);

            // #1
            // Console.WriteLine("Please enter 5 numbers separated by dashes");
            // var input = Console.ReadLine();
            // var split = input.Split('-');
            // var numList = new List<int>();
            // foreach (var numstr in split)
            //     numList.Add(Convert.ToInt32(numstr));
            // int flag = (numList[1] > numList[0]) ? 1 : -1;
            // bool consecutive = false;
            // for (var i = 1; i < numList.Count; i++)
            // {
            //     if (numList[i] != numList[i - 1] + flag)
            //         break;
            //     if (i == numList.Count - 1)
            //         consecutive = true;
            // }
            // if (consecutive)
            //     Console.WriteLine("Consecutive");
            // else
            //     Console.WriteLine("Not Consecutive");

            // #2
            // Console.WriteLine("Please enter 5 numbers separated by dashes");
            // var input = Console.ReadLine();
            // if (!String.IsNullOrEmpty(input))
            // {
            //     var split = input.Split('-');
            //     var numbers = new List<int>();
            //     foreach (var numstr in split)
            //     {
            //         var thisNumber = Convert.ToInt32(numstr);
            //         var index = numbers.IndexOf(thisNumber);
            //         if (index != -1)
            //         {
            //             Console.WriteLine("Duplicate");
            //             break;
            //         }
            //         numbers.Add(thisNumber);
            //     }
            // }

            // #3
            // Console.WriteLine("Please enter a valid time in the 24 hour format (00:00): ");
            // var input = Console.ReadLine();
            // if (!String.IsNullOrEmpty(input))
            // {
            //     var split = input.Split(":");
            //     if (split.Length != 2 || split[0].Length != 2 || split[1].Length != 2)
            //         Console.WriteLine("Invalid Time");
            //     else
            //     {
            //         var hoursByte = Convert.ToByte(split[0]);
            //         var minutesByte = Convert.ToByte(split[1]);

            //         if (0 > hoursByte || hoursByte > 23)
            //             Console.WriteLine("Invalid Time");
            //         else if (0 > minutesByte || hoursByte > 59)
            //             Console.WriteLine("Invalid Time");
            //         else
            //             Console.WriteLine("Ok");
            //     }
            // }

            // #4
            // Console.WriteLine("Type as many words as you like: ");
            // var input = Console.ReadLine();
            // var strings = input.Split(" ");
            // var pascal = new List<string>();
            // foreach(var str in strings)
            // {
            //     var newStr = str.ToLower();
            //     newStr = newStr[0].ToString().ToUpper() + newStr.Substring(1);
            //     pascal.Add(newStr);
            // }
            // foreach(var str in pascal)
            //     Console.Write(str);
            // Console.WriteLine();

            // #5
            // Console.WriteLine("Enter an English word: ");
            // var input = Console.ReadLine();
            // var vowels = new char[5] {'a', 'e', 'i', 'o', 'u'};
            // var count = 0;
            // for (int i = 0; i < input.Length; i++)
            // {
            //     if (Array.IndexOf(vowels, input[i]) != -1)
            //         count++;
            // }
            // Console.WriteLine(count);

            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);

            Console.WriteLine("Reversed Name: " + reversed);
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            return new string(array);
        }
    }
}
