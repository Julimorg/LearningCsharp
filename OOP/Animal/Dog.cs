using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.OOP.Animal
{
    public class Dog : Animal, IAnimal
    {
        private string ownerName;

        public Dog(string name, string type, string gender, int number, string ownerName) : base(name, type,gender,number)
        {
            this.ownerName = ownerName;
        }
        public string OwnerName { get; set; }

        public override void IntroduceAnimal() {
            Console.WriteLine($"{ownerName} say hi");
            
        }
        public void MakeSound() {
            Console.WriteLine($"woof woof");
        }
        


    }
}