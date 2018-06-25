using System;

namespace Classes
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express =3
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var john = new Person();
            // john.FirstName = "John";
            // john.LastName = "Smith";
            // john.Introduce();

            // var calculator = new Calculator();
            // var result = calculator.Add(1 ,2);
            // Console.WriteLine(result);

            // var numbers = new int[3];
            // numbers[0] = 1;

            // Console.WriteLine(numbers[0]);
            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers[2]);

            // var flags = new bool[3];
            // flags[0] = true;

            // Console.WriteLine(flags[0]);
            // Console.WriteLine(flags[1]);
            // Console.WriteLine(flags[2]);

            // var firstName = "Kyle";
            // var lastName = "Murray";

            // var fullName = firstName + " " + lastName;

            // var myFullName = string.Format("{0} {1}", firstName, lastName);
            // Console.WriteLine(fullName);
            // Console.WriteLine(myFullName);

            // var names = new string[3] {"Jack", "John", "Mary"};
            // var formattedNames = string.Join(",", names);
            // Console.WriteLine(formattedNames);

            // var method = ShippingMethod.Express;
            // Console.WriteLine((int)method);

            // var methodId = 3;
            // Console.WriteLine((ShippingMethod)methodId);

            // // Console.WriteLine(method.ToString());
            // Console.WriteLine(method);

            // var methodName = "Express";
            // var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            // Console.WriteLine(shippingMethod);
        
            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;

            array2[0] = 0;
            Console.WriteLine(string.Format("{0} {1} {2}", array1[0], array1[1], array1[2]));
        }
    }
}
