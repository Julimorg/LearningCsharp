using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Car
{
    public class Car
    {
        private string carName;
        private double price;
        private int quantity;

        public Car(string carName, double price, int quantity)
        {
            this.carName = carName;
            this.price = price;
            this.quantity = quantity;
        }

        public string CarName
        {
            get => carName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    carName = value;
                else
                    throw new ArgumentException("Name cannot be empty or null.");
            }
        }

        public double Price
        {
            get => price;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Price cannot be negative or zero.");
                price = value;
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Quantity cannot be negative or zero.");
                quantity = value;
            }
        }


        public void CarIntroduce()
        {
            Console.WriteLine($"{carName} - {price} - {quantity}");
        }
    }
}