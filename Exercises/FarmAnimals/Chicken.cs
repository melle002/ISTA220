using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm
{
    class Chicken:Animal
    {
        public Chicken(string chickenName) : base(chickenName)
        {
            this.Sound = "bock bock bock";
            this.Name = chickenName;
            this.Consistency = "stinky turds";
            this.Movement = "laying eggs";
            this.Species = "Chicken";
            this.Food = "grain";
        }

    }
}
