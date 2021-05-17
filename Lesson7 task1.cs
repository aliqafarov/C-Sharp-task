using System;
using System.Collections.Generic;
namespace ConsoleApp
{
    interface ISimpleAngle
    {
        int Height { get; set; }
        int SidesCount { get; set; }
        int [] SidesLenght { get; set; }

        int Area { get; set; }
        int Perimeter { get; set; }
        public int area();
        public int perimeter();
    }

     abstract class GeometricFigure
    {
        public int _area;
        public int _perimeter;
       
    }

    class Rectangle : GeometricFigure, ISimpleAngle
{
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int area()
        {
            return side1 * side2;
        }
        public  int perimeter()
        {
            return (side1 + side2) * 2;
        }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SidesCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int[] SidesLenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Perimeter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Triangle : GeometricFigure, ISimpleAngle
{
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int area()
        {
            return side1 * side2*side3;
        }
        public int perimeter()
        {
            return side1 + side2+ side3;
        }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SidesCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int[] SidesLenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Perimeter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class Square : GeometricFigure, ISimpleAngle
{
        public int PI = 3;
        public int radius { get; set; }
        public  int area()
        {
            return PI * radius *radius;
        }
        public int perimeter()
        {
            return 2 *PI *radius;
        }
        public int Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SidesCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int[] SidesLenght { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Perimeter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class ComplexFigure
    {
       private List<ISimpleAngle> arr =new List<ISimpleAngle> { };

       public void Add(ISimpleAngle obj)
        {
            arr.Add(obj);
        }

       public int printArea()
        {
            int value=0;
            foreach (var item in arr)
            {
                value += item.area();
            }
            return value;
        }

        public int printPerimeter()
        {
            int value = 0;
            foreach (var item in arr)
            {
                value += item.perimeter();
            }
            return value;
        }

    }
    class Program
    {
        static int Method() =>1;
        static void Main(string[] args)
        {
            
        }

        
    }
}
