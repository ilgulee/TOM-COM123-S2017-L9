using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L9
{
    public class SuperHuman:Human
    {
        public List<Power> Powers { get; private set; }
        public SuperHuman(string name)
            :base(name)
        {
            _initialize();
        }

        private void _initialize()
        {
            this.Powers = new List<Power>();
        }

        public void AddPower(string name,int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        public void DisplayPowers()
        {
            foreach (var power in this.Powers)
            {
                Console.WriteLine("Power: "+power.Name+" Rank: "+power.Rank);
            }
        }
    }
}
