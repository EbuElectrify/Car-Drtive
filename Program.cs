using System;

namespace interfaceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the amout of gasoline for refuel (Hint: 0 to any number)");
                Car car = new Car(0); //object for class car
        int gasoline = int.Parse(Console.ReadLine()); //input amount of gasoline
        if (car.Refuel(gasoline))
        {
            car.Drive();
        }
        }
    }
    //interface declaration
    public interface IVehicle
    {
        // methods having only declaration
        void Drive();
        bool Refuel(int amount);
    }
    //A class that implements the interface.
    public class Car : IVehicle
    {
        public int Gasoline { get; set; }
 
        public Car(int gasoline)
        {
            Gasoline = gasoline;
        }
        //drive method
        public void Drive()
        {
            if (Gasoline > 0)
            {
                Console.WriteLine("The Car is driving");
            }
            else
            {
                Console.WriteLine("No fuel, car can't drive");
            }
        }
 
        public bool Refuel(int amount)
        {
            Gasoline += amount;
            return true;
        }
    }

}
