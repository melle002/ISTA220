using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm
{
    class Pig:Animal
    {
        public Pig(string pigName) : base(pigName)
        {
            this.Sound = "oink";
            this.Name = pigName;
            this.Consistency = "wet turds";
            this.Movement = "Waddling in the mud";
            this.Species = "Pig";
            this.Food = "slop";

        }
    }
}
