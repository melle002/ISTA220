using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm    
{
    class Program
    {
        static void Main()                             // constructor (populates farm and calls methods for all animals)
        {
            Pig myPig1 = new Pig("Charlotte");         //creates new instance of Pig with name "Charlotte"
            myPig1.Everything();                      // calls the everything method from Animal.cs

            Goat myGoat1 = new Goat("Billy");
            myGoat1.Everything();

            Horse myHorse1 = new Horse("Dart");
            myHorse1.Everything();

            Chicken myChicken1 = new Chicken("Chicken Little");
            myChicken1.Everything();

        }
    }
}
