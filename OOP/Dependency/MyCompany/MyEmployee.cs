using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCsharp.OOP.Dependency.MyCompany
{
    public class MyEmployee
    {
        private string name;
        private MyManager manager;

        public MyEmployee(string name, MyManager manager)
        {
            this.name = name;
            this.manager = manager;
        }
        public string getManagerName()
        {
            return manager.getName();
        }
        public string getName()
        {
            return name;
        }
    }
}