using System;

namespace CircleAndCylinder
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Circle");
            Circle circle = new Circle(3.5,"Red");
            Console.WriteLine(circle);
            Console.WriteLine("Cylinder");
            Cylinder cylinder = new Cylinder(5,3.5,"Red");
            Console.WriteLine(cylinder);
        }
    }
}