using System;
using System.Collections.Generic;

namespace ConsoleApp
{
   
    abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Triangle : Figure
    {
         public double side1 { get; set; }
         public double side2 { get; set; }
         public double side3 { get; set; }
        public override double Area()
        {
            return side1 * side2 * side3;
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
    }

    class Circle : Figure
    {
        public double Radius { get; set; }

        public double Pi = 3.14;
        public override double Area()
        {
            return 2* Pi* Radius;
        }

        public override double Perimeter()
        {
            return Pi*Radius *Radius;
        }
    }

    class Rhombus : Figure
    {
        public double side { get; set; }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    class Square : Figure
    {
        public double side { get; set; }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

    class Rectangle : Figure
    {
        public double side1;

        public double side2;

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return 2 * (side1 + side2);
        }
    }

    class Parallelogram : Figure
    {
        public double side1 { get; set; }

        public double side2 { get; set; }

        public double height1 { get; set; }

        public double height2 { get; set; }

        Parallelogram()
        {
            side1 = 0;
            height1 = 0;
            side2 = 0;
            height2 = 0;
        }

        
        public override double Area()
        {
            if (height2 == 0) return side1 * height1;

            else return side2 * height2;
        }

        public override double Perimeter()
        {
             return 2 * (side1 + side2);
        }
    }


    class CompositeFigure
    {
         private List<Figure> figure;

        public CompositeFigure(List<Figure>arr)
        {
            figure = arr;
        }

        public void print()
        {
            foreach(var item in figure)
            {
                Console.WriteLine("Area : " + item.Area());
                Console.WriteLine("Perimeter : " + item.Perimeter());
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rhombus romb = new Rhombus();
            romb.side=5;

            Circle circle = new Circle();
            circle.Radius = 3;
            List<Figure>list = new List<Figure>{ romb,circle};
            CompositeFigure test = new CompositeFigure(list);

            test.print();
        }

    }

}
