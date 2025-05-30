using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Dependency.Printer
{
    public class EmployeePrinter
    {
        private string name;

        public EmployeePrinter(string name)
        {
            this.name = name;
        }
        public void PrintDocument(Printer printer)
        {
            Console.WriteLine($"{name} use {printer.getModel()}");
            
        }

        public string getName()
        {
            return name;
        }
    }
}