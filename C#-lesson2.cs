using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            int result = C / A * C / B;
            if (C > A || C > B) Console.WriteLine("Wrong variable");
            else
            {
                Console.WriteLine( "Result: " + (A / C * B / C));
            }
        }
    }
}
