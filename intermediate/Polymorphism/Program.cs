using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // METHOD OVERRIDING

            // var list = new List<Shape>();
            // list.Add(new Circle());
            // list.Add(new Rectangle());
            // list.Add(new Circle());
            
            // var canvas = new Canvas();
            // canvas.DrawShapes(list);

            // ABSTRACT CLASSES AND MODIFIERS
            // var circle = new Circle();
            // var rectangle = new Rectangle();
            // // var shape = new Shape();

            // circle.Copy();
            // circle.Draw();
            // rectangle.Copy();
            // rectangle.Draw();

            // EXERCISES

            var sql = new SqlConnection("sqlcnx");
            var oracle = new OracleConnection("oraclecnx");

            var sqlCommand = new DbCommand(sql, "T-SQL something here.");
            sqlCommand.Execute();
            var oracleCommand = new DbCommand(oracle, "Oracle language something here.");
            oracleCommand.Execute();
            
        }
    }
}
