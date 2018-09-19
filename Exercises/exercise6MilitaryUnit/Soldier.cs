using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6MilitaryUnit
{
    class Soldier : Unit
    {
        public virtual void Cff()
        {
            Console.WriteLine("FIRE FOR EFFECT   GRID: 123 456 ALT 200 BREAK...DIRECTION: 3200");
            Console.WriteLine("2 Rds HE Fuze Quick");
            Console.WriteLine("TROOPS IN THE OPEN, AT MY COMMAND");

        }
        public virtual void Compute()
        {
            Console.WriteLine("FDC Computes Firing Solution and checks data");
            
        }
        public virtual void Transmit()
        {
            Console.WriteLine("FIRE MISSION");
            Console.WriteLine("2 Rds HE CHARGE 6 FUZE Quick SPECIAL INSTRUCTIONS: At My Command DEFLECTION 3173 QUADRANT 367");
        }
        public virtual void Ready()
        {
            Console.WriteLine("READY");
        }
        public virtual void Fire()
        {
            Console.WriteLine("FIRE!!!");
        }
    }
}
