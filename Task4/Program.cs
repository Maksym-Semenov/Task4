using System;
using System.Runtime.ConstrainedExecution;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" how many?");
            //int value = Convert.ToInt32(Console.ReadLine());
            var car = new Car[3];
            Car car0 = new Car();
            Car car1 = new Car("X3", "black", 15000);

           
            for (int i = 2; i < car.Length; i++)
            {
                car[i] = Car.Input(i);
            }
            for (int i = 0; i < car.Length; i++)
            {
                car[i].Output();
            }
            
            Console.ReadLine();
            
            //for (int i = 0; i < value; i++)
            //{
            //    Сar.Output(i);
            //}
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    car[i] = Car.Input(i);
            //}
        }
    }
}
