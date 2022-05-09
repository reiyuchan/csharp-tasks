using System;

namespace Vehicle.car
{
    public class Car : Vehicle
    {
        public Car(double distance, int time,double fuel) : base(distance, time,fuel)
        {
        }
        public override void Speed()
        {
            double speed = (distance * 0.621371) / time;
            Console.WriteLine("Car speed is {0:0.00} miles/h", speed);
        }
        public void Average()
        {
            double avg = distance / fuel;
            Console.WriteLine("Average distance with Vehicle fuel = {0:0.00}", avg);
        }
    }
}