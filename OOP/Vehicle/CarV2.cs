using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Vehicle
{
    public class CarV2 : CarV1
    {
        public string Road { get; set; }
        public CarV2(string brand, int price, string racer, string road) : base(brand, price, racer)
        {
            Road = road;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Racer} drive the {Brand} with {Price}");
        }



    }
}