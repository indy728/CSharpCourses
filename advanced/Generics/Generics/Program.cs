using System;
using System.Collections.Generic;

namespace Generics
{
    public class Book : Product
    {
        public string Isbn { get; set; }
    }

    public class BookList
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }

    //public class List
    //{
    //    public void Add(object value)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public object this[int index]
    //    {
    //        get { throw new NotImplementedException(); }
    //    }

    //}

    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
            
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T Value){
            var obj = new T();
        }

        // Generic method inside of non-generic class 
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    // where T : IComparable
    // where T : struct (value type)
    // where T : class
    // where T : new() (default constructor)

    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
            
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { Name = "The Wind in the Willows", Isbn = "1234" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(book);

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
            Console.WriteLine();
            var number2 = new Nullable<int>();
            Console.WriteLine("Has Value?" + number2.HasValue);
            Console.WriteLine("Value: " + number2.GetValueOrDefault());

        }
    }
}
