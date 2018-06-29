using System;

namespace Inheritance
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Text : Shape{
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}