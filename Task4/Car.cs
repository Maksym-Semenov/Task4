using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Car
    {
        public const string CompanyName = "BMW";
        string name;
        string colour;
        double price;
        public string Colour { get { return colour; } set { colour = value; } }
        public Car()
        {
            name = "X1";
            colour = "white";
            price = 10000;
        }
        public Car(string name, string colour, double price)
        {
            this.name = name;
            this.colour = colour;
this.price = price;
        }
        public static Car Input(int i)
        {
            Console.Write($"Enter model car {i + 1}:\t");
            string _name = Console.ReadLine();
            Console.Write("Enter colour car:\t");
            string _colour = Console.ReadLine();
            Console.Write("Enter price car:\t");
            double _price = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(_name, _colour, _price);
            return car;
        }
        public void Output()
        {
            Console.WriteLine($"{CompanyName} Model {name}, Colour is {colour}, Price is: {price}");
        }
        public double ChangePrice(double percent)
        {
            price = price * percent / 100;
            return price;
        }
        public static bool operator ==(Car first, Car second)
        {
            return first.name == second.name && first.price == second.price;
        }
        public static bool operator !=(Car first, Car second)
        {
            return !(first == second);
        }
        public override string ToString()
        {
            return ($"{CompanyName} Model: {name}, Colour: {colour}, Price: {price}");
        }
    }
}
