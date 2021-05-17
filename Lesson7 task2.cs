using System;
using System.Collections.Generic;

namespace ConsoleApp
{
 
    enum Colour
    {
        black =1,
        green,
        white,
        yellow,
        red,
        blue
    }

    abstract class Figure
    {
        public Colour colour { get; set; }

        abstract public void printFigure();

    }


    
    class Square : Figure
    {
        public int side { get; set; }

        public Square(int num, Colour c)
        {
            side = num;
            colour = c;
        }
        public override void printFigure()
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    if (i == 0 || i == side - 1 || j == 0 ||j==side-1)
                    {
                        Console.Write("*");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static int Method() =>1;
        static void Main(string[] args)
        {
            Square s = new Square(10, Colour.red);
            s.printFigure();
        }

        
    }
}
