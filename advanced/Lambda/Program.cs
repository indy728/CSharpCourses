using System;
using System.Collections.Generic;

namespace Lambda
{

    public class Book
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
    public class BookRepo
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "One", Price = 10.99f },
                new Book() {Title = "Two", Price = 20.99f },
                new Book() {Title = "Three", Price = 30.99f }
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // args (goes to) expression
            // number => number * number;

            // () => ...
            // x => ...
            // (x, y, z) => ...

            // Func<int, int> square = Square;
            Func<int, int> square = number => number * number;

            Console.WriteLine(square(5));
            

            const int factor = 5;

            Func<int, int> multiplyer = n => n*factor;
            Console.WriteLine(multiplyer(50));

            var books = new BookRepo().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 25.00f);

            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title + " is cheaper that $25.00");

        }
    }
}
