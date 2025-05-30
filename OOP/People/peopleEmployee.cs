using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.People
{

    public class peopleEmployee : People
    {
        private int Salary { get; set; }
        public peopleEmployee(string name, string address, int salary) : base(name, address)
        {
            Salary = salary;
        }

        public override void display()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}