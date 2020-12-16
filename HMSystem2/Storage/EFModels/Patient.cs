using System;
using System.Collections.Generic;

namespace HMSystem.Storage.EFModels
{
    public class Patient : Member
    {
        public Guid PatientId {get; set;}
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public DateTime DateAdmitted { get; set; }
        public string Symptom { get; set; }
        public double BillPerDay { get; set; }
        public double MedicationFees { get; set; }
        public double LabFees { get; set; }
        public double RehabFees { get; set; }
        public bool IsCheckedOut { get; set; }
        public Room Room { get; set; }
        public Guid RoomId { get; set; }
        public int PatientDaysInHospital { get; set; }
       
    }
}