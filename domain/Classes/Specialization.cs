using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Classes
{
    class Specialization
    {
        public uint ID;
        public string name;

        Specialization(uint id, string name)
        {
            ID = id;
            this.name = name;
        }
    }
}
