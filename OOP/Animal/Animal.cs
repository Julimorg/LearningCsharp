using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Animal
{
    public class Animal
    {
        private string name;
        private string type;
        private string gender;
        private int number;

        //? Constructor Parameter with this keyword
        public Animal(string name, string type, string gender, int number)
        {
            this.name = name;
            this.type = type;
            this.gender = gender;
            this.number = number;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public int Number { get; set; }

        public virtual void IntroduceAnimal()
        {

            if (this.number < 10)
            {
                Console.WriteLine($"{name} is {type}, {gender}. Now {name} numbers are about {number} and its nearly disapp...");
            }
            else
            {
                Console.WriteLine($"{name} is {type}, {gender}. Now {name} numbers are about {number} and its still large...");

            }
        }




    }
}