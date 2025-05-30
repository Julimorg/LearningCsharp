using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.People
{
    public abstract class People
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public People(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void display()
        {
            Console.WriteLine($"{Name} -- {Address}");
        }

    }
}