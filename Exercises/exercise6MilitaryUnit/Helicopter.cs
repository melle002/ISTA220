using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6MilitaryUnit
{
    class Helicopter:Vehicle
    {
        public virtual void Hover()
        {
            Console.WriteLine("Helocopters are hovering");
        }
        public virtual void Land()
        {
            Console.WriteLine("Helicopters have landed");
        }
    }
}
