using System;

namespace Polymorphism
{
    public abstract class Shape
    {
    //     public int Width { get; set; }
    //     public int Height { get; set; }
    //     public Position Position { get; set; }
        // public ShapeType Type { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Shape has been copied to the slipboard.");
        }
    }

    // public struct Position
    // {
    //     int x;
    //     int y;
    // }
    // public enum ShapeType
    // {
    //     Circle,
    //     Rectangle
    // }
    // public class Text : Shape{
    //     public int FontSize { get; set; }
    //     public string FontName { get; set; }
    // }

    public class Circle : Shape
    {
        public override void Draw()    
        {
            // base.Draw();
            Console.WriteLine("Draw a circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Draw a rectangle");
        }

    }
}