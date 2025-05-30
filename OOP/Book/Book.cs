using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Book
{
    class Book
    {

        private string name;
        private string author;
        private int quantity;
        private double price;

        public Book(string name, string author, double price, int quantity)
        {
            this.name = name;
            this.author = author;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new ArgumentException("Tên sách không được rỗng hoặc null.");
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    author = value;
                else
                    throw new ArgumentException("Tác giả không được rỗng hoặc null.");
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Số lượng không được âm hoặc bằng không.");
                quantity = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Giá không được âm hoặc bằng không.");
                price = value;
            }
        }

        public void BookIntroduce()
        {
            Console.WriteLine($"{name} - {author} - {quantity} - {price}");
        }
    }
}