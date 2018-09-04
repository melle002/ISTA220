using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ellersFarm
{
    class Goat:Animal
    {
        public Goat(string goatName) : base(goatName)
        {
            this.Sound = "AAAAAAAHHHHHHHHHH!!!!!";
            this.Name = goatName;
            this.Consistency = "pellets";
            this.Movement = "standing on a rock";
            this.Species = "Screaming Goat";
            this.Food = "anything";
        }





    }
}
