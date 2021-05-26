
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using MyClassLibrary;
using MyClassLibrary.WorldOfTanks;

namespace ConsoleApp3
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            Pantera[] pantera = new Pantera[5];
            T34[] t34 = new T34[5];
            for (int i = 0; i < 5; i++)
            {
                pantera[i] = new Pantera("pantera" + (i + 1), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
                t34[i] = new T34("T34" + (i + 1), random.Next(0, 100), random.Next(0, 100), random.Next(0, 100));
            }

            Console.WriteLine("Name     " + "Ammunition Level     " + " Armor Level     " + "Maneuverability");
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine(pantera[i].GetName() + "        " + pantera[i].GetAmmunitionLevel() + "                 " + pantera[i].GetArmorLevel() + "              " + pantera[i].GetManeuverability());

            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" " +t34[i].GetName() + "           " + t34[i].GetAmmunitionLevel() + "                 " + t34[i].GetArmorLevel() + "              " + t34[i].GetManeuverability());
            }

            Console.WriteLine();
            Console.WriteLine();
            bool check = true;
            int number = 0;
            for (int i = 0; i < 5; i++)
            {
                check=pantera[i] * t34[i];
                if (check) number++;
            }

            if (number > 2) Console.WriteLine("Pantera team won");
            else Console.WriteLine("T34 team won");
        }
    }
}
