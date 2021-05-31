using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LessonsProject
{
    class StartRaceArgs : EventArgs
    {
        
    }

    class FinishRaceArgs : EventArgs
    {
       public string Winner { get; set; }
    }
    class Vehicle
    {
        public event EventHandler<StartRaceArgs> startVehicleEvent;
        public event EventHandler<FinishRaceArgs> finishVehicleEvent;
        private List<Car> carList = new List<Car>();
        public delegate int Mydelegate();
        public void  AddCarForRace(Car car)
        {
            carList.Add(car);
            startVehicleEvent += car.Start;
        }
        public void StartRace()
        {
            startVehicleEvent(this, new StartRaceArgs());
            int speed = carList[0].speed;
            int index = 0;
            for (int i = 1; i < carList.Count; i++)
            {
                if (speed < carList[i].speed)
                {
                    index = i;
                    speed = carList[i].speed;
                }
            }
            finishVehicleEvent += carList[index].Finish;
        }

        public void FinishRace()
        {
            int speed = carList[0].speed;
            int index = 0;
            for (int i = 1; i < carList.Count; i++)
            {
                if (speed < carList[i].speed)
                {
                    index = i;
                    speed = carList[i].speed;
                }
            }
            finishVehicleEvent(this, new FinishRaceArgs() { Winner = $"{carList[index].speed} speed" });
        }
    }


    abstract class Car
    {
        public int speed;
        public string carName;
        public Car(string name)
        {
            carName = name;
        }
        public Random random = new Random();
        public abstract void Start(object sender, StartRaceArgs obj);
        public abstract void Finish(object sender, FinishRaceArgs obj);
        public abstract int GetSpeed();
    }

    class BMW : Car
    {

        public BMW(string name) : base(name)
        {

        }
        public override void Finish(object sender, FinishRaceArgs obj)
        {
            Console.WriteLine($"BWM win the race with  {obj.Winner}");
        }

        public override int GetSpeed()
        {
            return speed;
        }

        public override void Start(object sender, StartRaceArgs obj)
        {
            speed = random.Next(0, 100);
            Console.WriteLine("BWM is ready for race");
        }
    }

    class Toyota : Car
    {

        public Toyota(string name) : base(name)
        {

        }
        public override void Finish(object sender, FinishRaceArgs obj)
        {
            Console.WriteLine($"Toyota win the race with  {obj.Winner}");
        }

        public override int GetSpeed()
        {
            return speed;
        }
        public override void Start(object sender, StartRaceArgs obj)
        {
            speed = random.Next(0, 100);
            Console.WriteLine("Toyota is ready for race");
        }
    }

    class Kia : Car
    {
        public Kia(string name) : base(name)
        {

        }
        public override void Finish(object sender, FinishRaceArgs obj)
        {
            Console.WriteLine($"Kia win the race with  {obj.Winner}");
        }

        public override int GetSpeed()
        {
            return speed;
        }

        public override void Start(object sender, StartRaceArgs obj)
        {
            speed = random.Next(0, 100);
            Console.WriteLine("Kia is ready for race");
        }
    }
    class Program
    {
        public static void Main()
        {
            Vehicle vehicle = new Vehicle();
            BMW bmw = new BMW("X5");
            Toyota toyota = new Toyota("Prius");
            Kia kia = new Kia("Optima");
            vehicle.AddCarForRace(bmw);
            vehicle.AddCarForRace(toyota);
            vehicle.AddCarForRace(kia);
            vehicle.StartRace();
            vehicle.FinishRace();
        }
    }
}
