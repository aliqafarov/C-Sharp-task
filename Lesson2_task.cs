using System;

namespace ConsoleApp3
{
    partial class Car
    {
        private string _mark;
        private char _category;
        private bool _readyForSales;
        private short? _maxSpeed;
        private double _weight;
        private int _id;
        private int _salesNumber;
        

        public Car()
        {
            _mark = "Unknown";
            _category = 'A';
            _readyForSales = false;
            _maxSpeed = 200;
            _weight = 100;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }
        public Car(string mark, char cat, bool status, short speed, double weight)
        {
            _mark = mark;
            _category = cat;
            _readyForSales = status;
            _maxSpeed = speed;
            _weight = weight;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }
        public Car(string mark, char cat, bool status, double weight)
        {
            _mark = mark;
            _category = cat;
            _readyForSales = status;
            _maxSpeed = null;
            _weight = weight;
            ID++;
            SalesNumber++;
            _id = ID;
            _salesNumber = SalesNumber;
        }

         

        public short? speed()
        {
            return _maxSpeed;
        }

        public void  chanceStatus(bool status)
        {
            _readyForSales = status;
        }
    }


    partial class Car
    {
        static private int ID;

        static private int SalesNumber;
        static Car()
        {
            ID = 0;
            SalesNumber = 999000;

        }
        public void print()
        {
            Console.WriteLine(_id);
            Console.WriteLine(_salesNumber);
            Console.WriteLine(_mark);
            Console.WriteLine(_category);
            Console.WriteLine(_readyForSales);
            Console.WriteLine(_maxSpeed);
            Console.WriteLine(_weight);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car[] obj2 = new Car[5];
            for (int i = 0; i < 5; i++)
            {
                obj2[i] = new Car();
            }

            for (int i = 0; i < 5; i++)
            {
                obj2[i].print();
                Console.WriteLine();
            }
        }


    }

}
