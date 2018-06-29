using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // ACCESS MODIFIERS

            // var customer = new Customer();
            // customer.Id = 2;
            // customer.CalculateRating();

            // CONSTRUCTORS

            // var car = new Car("1Z90834");

            // UPCASTING AND DOWNCASTING

            // Text text = new Text();
            // Shape shape = text;

            // text.Width = 200;
            // // we'll see here that 'shape' references 'text'
            // shape.Width = 100;

            // Console.WriteLine(text.Width);

            // StreamReader reader = new StreamReader(new MemoryStream());
            // var list = new ArrayList();
            // list.Add(1);
            // list.Add("Mosh");
            // list.Add(new Text());

            // var anotherList = new List<Shape>;

            // Shape shape = new Text();
            // Text text = (Text) shape;
            
            // BOXING & UNBOXING

            // var list = new ArrayList();
            // // ArrayList creates a list of objects. When we add
            // // the following, they are boxed and added to the heap
            // // as objects.
            // list.Add(1);
            // list.Add("Kyle");
            // list.Add(DateTime.Today);

            // var anotherList = new List<int>();
            // anotherList.Add("Not an int");
            // var names = new List<string>();
            // names.Add(69);

            // EXERCISE: DESIGN A STACK

            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Push("Lexi");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
