using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        //    var person = new Person();
        //    person.SetBirthdate(new DateTime(1987, 7, 28));
        //    Console.WriteLine(person.GetBirthdate());
       
        //    var person = new Person(new DateTime(1987, 7, 28));
        //    Console.WriteLine(person.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "Kyle";
            Console.WriteLine(cookie["name"]);

        }
    }
}
