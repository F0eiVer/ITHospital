using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace domain
{
    public class Role
    {
        public uint ID;
        Role(uint id)
        {
            ID = id;
        }
    }

    public class Specialization
    {
        public uint ID;
        public string name;

        Specialization(uint id, string name)
        {
            ID = id;
            this.name = name;
        }
    }

    public class User
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

    public class Doctor
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

    public class Appointment
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

    public class Timetable
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