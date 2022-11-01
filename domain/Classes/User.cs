using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Classes
{
    class User
    {
        public uint ID;
        public int phoneNumber;
        public string fullName;
        public Role role;

        User(uint id, int phone, string FName, Role role)
        {
            ID = id;
            phoneNumber = phone;
            fullName = FName;
            this.role = role;
        }
    }
}
