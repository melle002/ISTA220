using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6MilitaryUnit
{
    class Vehicle : Unit
    {

        public virtual void StartEngine(string noiseToMakeWhenStarting)

        {

            Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");

        }

        public virtual void StopEngine(string noiseToMakeWhenStopping)

        {

            Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");

        }

        public virtual void Drive()

        {

            Console.WriteLine("Why is it taking so long");

        }

        /*public override void Load()

        {

            Console.WriteLine("Loading Soldiers");

        }*/

    }

}
