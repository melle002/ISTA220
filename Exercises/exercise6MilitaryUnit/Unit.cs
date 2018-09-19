using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6MilitaryUnit
{
    class Unit
    {

        public virtual void Loading(string noiseToMakeWhenLoading)

        {

            Console.WriteLine($"Loading: {noiseToMakeWhenLoading}");

        }

        public virtual void Firing(string noiseToMakeWhenFiring)

        {

            Console.WriteLine($"Firing: {noiseToMakeWhenFiring}");

        }
        public virtual void Unloading(string noiseToMakeWhenUnloading)
        {
            Console.WriteLine($"Unloading: {noiseToMakeWhenUnloading}");
        }

    }

}
