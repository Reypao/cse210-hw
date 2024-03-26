using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>();

            Square sq = new Square("Yellow", 3);
            shapes.Add(sq);

            Rectangle rec = new Rectangle("Red", 4, 5);
            shapes.Add(rec);

            Circle cir = new Circle("Pink", 6);
            shapes.Add(cir);

            foreach (Shape s in shapes)
            {
                string color = s.GetColor();

                double area = s.GetArea();

                Console.WriteLine("The "+ color + " shape has an area of " + area + ".");
           
            }
            Console.ReadKey();
        }
    }
}