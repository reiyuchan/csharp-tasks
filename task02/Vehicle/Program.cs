using System;
using Vehicle.car;

namespace Vehicle
{
    public class Vehicle
    {
        protected double distance;
        protected int time;
        protected double fuel;

        public Vehicle(double distance, int time, double fuel)
        {
            this.distance = distance;
            this.time = time;
            this.fuel = fuel;
        }
        public virtual void Speed()
        {
            double speed = distance / time;
            Console.WriteLine("Vehicle speed is {0:0.00} km/h",speed);
        }
        public void Average()
        {
            double avg = distance / fuel;
            Console.WriteLine("Average distance with Vehicle fuel = {0:0.00}",avg);
        }
    }

    public class Program
    {
        public static void Main(String[] args)
        {

            Console.Write("Enter the distance (in Kilometers): ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the required time to reach this distance (in Hours): ");
            int time = int.Parse(Console.ReadLine());
            Console.Write("Enter the fuel: ");
            double fuel = double.Parse(Console.ReadLine());
            Vehicle vehicle = new Vehicle(distance, time,fuel);
            vehicle.Speed();
            Car car = new Car(distance, time,fuel);
            car.Speed();
        }
    }
}