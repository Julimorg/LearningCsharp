using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learning.OOP.Vehicle;

namespace Learning.OOP.Vehicle
{
    public class CarV1 : Vehicle
    {
        public string Racer { get; set; }
        public CarV1(string brand, int price, string racer) : base(brand, price)
        {
            Racer = racer;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"{Racer} drive the {Brand} with {Price}");
        }

    }
}