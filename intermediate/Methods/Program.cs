using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");

            int number;
            var result = int.TryParse("123", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }
        static void UseParams()
        {
            var calculator = new Calculator();
            var sum = calculator.Add(1, 2, 3, 4);
            Console.WriteLine("The sum of the numbers is " + sum);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40,60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(4,6);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}
