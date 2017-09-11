using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOM_COM123_S2017_L9
{
    public class Power
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public Power(string name,int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
    }
}
