using System;
using System.Runtime.ConstrainedExecution;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input numbers of car
            Console.Write(" how many cars are there?\t");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input info about cars:\t");
            var car = new Car[value];
            car[0] = new Car();
            car[1] = new Car("X3", "white", 15000);

            for (int i = 2; i < car.Length; i++)
            {
                car[i] = Car.Input(i);
            }
            for (int i = 0; i < car.Length; i++)
            {
                car[i].Output();
            }

            //Input discount
            Console.Write("Input discount:\t");
            double discount = int.Parse(Console.ReadLine());
            for (int i = 0; i < car.Length; i++)
            {
                car[i].ChangePrice(discount);
            }
            for (int i = 0; i < car.Length; i++)
            {
                car[i].Output();
            }

            //Input new colour and change
            Console.Write("Input new colour:\t");
            string newColour = Console.ReadLine();
            for (int i = 0; i < car.Length; i++)
            {
                if (car[i].Colour == "white")
                {
                    car[i].Colour = newColour;
                }
            }
            for (int i = 0; i < car.Length; i++)
            {
                car[i].Output();
            }

            //Overload operator ==
            for (int i = 0; i < car.Length - 1; i++)
            {
                for (int j = i + 1; j < car.Length; j++)
                {
                    if (car[i] == car[j])
                    {
                        Console.WriteLine($"Car {i + 1} are equlas Car {j + 1}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
