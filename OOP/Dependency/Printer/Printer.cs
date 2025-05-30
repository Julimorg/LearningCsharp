using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Dependency.Printer
{
    public class Printer
    {
        private string model;
        public Printer(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return model;
        }

        public void print()
        {
            Console.WriteLine($"{model} dang in");
        }
    }
}