using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm
{
    public class Animal
    {
        public Animal(string animalName)
        {
            this.Name = animalName;
        }

        public string Name;
        public string Sound;
        public string Food;
        public string Consistency;
        public string Movement;
        public string Species;

        public void Speak() { Console.WriteLine(this.Name + " speaks: " + this.Sound); }
        public void Eat() { Console.WriteLine(this.Name + " eats: " + this.Food); }
        public void Poop() { Console.WriteLine(this.Name + " poops" + this.Consistency); }
        public void Move() { Console.WriteLine(this.Name + this.Movement); }
        public void Everything() { Console.WriteLine(this.Name + " is a " + this.Species + " that eats " + this.Food + ", poops " + this.Consistency + ", while " + this.Movement + ", and says "  + this.Sound); }
        

    }
}
