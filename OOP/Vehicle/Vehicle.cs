using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Vehicle
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Price { get; set; }
        public Vehicle(string brand, int price)
        {
            Brand = brand;
            Price = price;
        }

        public virtual void StartEngine()
        {
            Console.WriteLine($"{Brand} - Price: {Price}");
        }

        public void Car()
        {
            Console.WriteLine("This car is awesome!");
        }
    }
}