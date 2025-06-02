using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCsharp.OOP.Dependency.MyCompany
{
    public class MyManager
    {
        private string name;
        public MyManager(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}