using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCsharp.OOP.Dependency.MyBook
{
    public class MyBook
    {
        private string name;
        private MyAuthor[] authors;
        private double price;

        public MyBook(string name, MyAuthor[] authors, double price)
        {
            this.name = name;
            this.authors = authors;
            this.price = price;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }
        public double getPrice()
        {
            return price;
        }
        public string getAuthorNames()
        {
            string authorNames = "";
            for (int i = 0; i < authors.length - 1; i++)
            {
                authorNames += authorNames[i].getName() + ", ";
            }
            authorNames += authors[authors.length - 1].getName();
            return authorNames;
        }
    }
}