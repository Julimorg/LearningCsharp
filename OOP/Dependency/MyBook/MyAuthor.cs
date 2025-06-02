using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCsharp.OOP.Dependency.MyBook;

namespace LearningCsharp.OOP.Dependency.MyBook
{
    public class MyAuthor
    {
        private string name;
        private string email;

        public MyAuthor(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
    }
}