using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Classes
{
    class Doctor
    {
        public uint ID;
        public string fullName;
        public Specialization specialization;

        Doctor(uint id, string FName, Specialization specialization)
        {
            ID = id;
            fullName = FName;
            this.specialization = specialization;
        }
    }
}
