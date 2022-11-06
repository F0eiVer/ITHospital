using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Classes
{
    class Timetable
    {
        public uint doctorID;
        public string startTime, finishTime;

        Timetable(string STime, string FTime, Doctor doctor)
        {
            startTime = STime;
            finishTime = FTime;
            doctorID = doctor.ID;
        }
    }
}
