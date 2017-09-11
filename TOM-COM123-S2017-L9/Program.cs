using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L9
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHuman = new SuperHuman("Super Dude");
            superHuman.Powers.Add(new Power("Spider Climbing", 50 ));
            superHuman.AddPower("Super Jumping", 60);
            superHuman.DisplayPowers();
        }
    }
}
