using System;
using HMSystem.Storage;

namespace HMSystem.Models
{
    public class Patient : Member
    {
        // Constructor
        public Patient(string title, string firstName, string lastName, DateTime dateOfBirth, long phoneNumber, string address, string symptom, DateTime dateAdmitted, char gender) 
            : base (firstName, lastName, phoneNumber, address) {
            PatientId = Guid.NewGuid();
            Title = title;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Symptom = symptom;
            DateAdmitted = dateAdmitted;
            BillPerDay = 350.00;
            IsCheckedOut = false;
           
        }
        // Data members
        public Guid PatientId {get; set;}
        public string Title { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Symptom { get; set; }
        public DateTime DateAdmitted { get; set; }
        public double BillPerDay { get; set; }
        public double MedicationFees { get; set; }
        public double LabFees { get; set; }
        public double RehabFees { get; set; }
        public bool IsCheckedOut { get; set; }
        public Room Room { get; set; }
        public Guid RoomId { get; set; }
        
        public int PatientDaysInHospital {
            get {
                var Now = DateTime.Now;
                var patientNumberOfDays = Now.Day - DateAdmitted.Day;
                return patientNumberOfDays;
            } 
            set { }
        }

        public double CalculateCharges {
            get {
                return ((BillPerDay * PatientDaysInHospital) + MedicationFees + LabFees + RehabFees);
            }
        }

        // Method
       public void CheckOut() {
            if (!IsCheckedOut) {
                IsCheckedOut = true;
            } else {
                throw new Exception($"Patient {PatientId} is already checked out!");
            }
        }
        
        public override string ToString() {
            string details = "";
            details += $"Name: {Title} {FullName}\n";
            details += $"Date of Birth: {DateOfBirth}\n";
            details += $"Phone number: {PhoneNumber}\n";
            details += $"Address: {Address}\n";
            details += $"Gender: {Gender}\n";
            details += $"Symptom: {Symptom}\n";
            return details + "\n";
        }
    }
}