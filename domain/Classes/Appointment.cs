using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Classes
{
    class Appointment
    {
        public string startTime, finishTime;
        public uint patientID, doctorID;

        Appointment(string STime, string FTime, User patient, Doctor doctor)
        {
            startTime = STime;
            finishTime = FTime;
            patientID = patient.ID;
            doctorID = doctor.ID;
        }
    }
}
