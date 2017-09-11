using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOM_COM123_S2017_L9
{

    public abstract class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            this.Name = name;
        }


    }
}