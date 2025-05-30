using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.People
{
    public class peopleCustomer : People
    {
        private int Balanace { get; set; }

        public peopleCustomer(string name, string address, int balance) : base(name, address)
        {
            Balanace = balance;
        }

        public override void display()
        {
            Console.WriteLine($"Balance: {Balanace}");
        }
    }
}