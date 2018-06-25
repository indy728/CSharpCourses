using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // var path = "/tmp/";
            // var testdup = path + "testdup.txt";

            // File.Copy(path + "test.txt", testdup);

            // if (File.Exists(testdup))
            // {
            //     var content = File.ReadAllText(testdup);
            //     Console.Write(content);
            //     File.Delete(testdup);
            // }

            // Console.WriteLine(testdup + " exists: " + File.Exists(testdup));


            // var fileInfor = new FileInfo(testdup);
            // fileInfo.CopyTo(path);
            // fileInfo.Delete();
            // if (fileInfo.Exists)
            // {
            //     // 
            // }

            // #1 & #2
            var path = "/Users/Marvin1/mirror_install/README.md";
            var content = File.ReadAllText(path);
            var words = new List<string>(content.Split(" "));
            Console.WriteLine("Number of words: " + words.Count);

            var longestWord = new StringBuilder();
            longestWord.Append(words[0]);
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                    longestWord.Clear().Append(word);
            }
            Console.WriteLine("Longest word: " + longestWord);
        }
    }
}
