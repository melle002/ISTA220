using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm
{
    class Horse: Animal
    {
        public Horse(string horseName) : base(horseName)
        {
            this.Sound = "Neeeeyyyyy";
            this.Name = horseName;
            this.Consistency = "huge green mounds";
            this.Movement = "galloping";
            this.Species = "Horse";
            this.Food = "hay";
        }
    }
}
