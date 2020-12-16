using System;
using System.Collections;
using System.Collections.Generic;

namespace HMSystem.Models
{
    public class Doctor : Member
    {
        //Constructor
        public Doctor(string lastName, string firstName, string specialization, long phoneNumber, string address, 
            string email, int numberOfPatient, string imageUrl) : base (firstName, lastName, phoneNumber, address) {
            DoctorId = Guid.NewGuid();
            Specialization = specialization;
            Email = email;
            ImageUrl = imageUrl;
            NumberOfPatient = numberOfPatient;
            Symptoms = new List<Symptom>();
            IsDoctorBooked = false;
        }

        
        // // Data members for the class Doctor
        public Guid DoctorId { get; set;}
        public string Specialization { get; set; }
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDoctorBooked { get; set; }
        public Symptom Symptom { get; set; }
        public List<Symptom> Symptoms { get; set; }
        public int NumberOfPatient { get; set; }

       

        
        // Methods
        public int DoctorCapacity() {
            return NumberOfPatient;
        }

        public void AddSymptom() {
            var symptom = new Symptom() {
                SymptomId = Guid.NewGuid(),
                SymptomName = Symptom.SymptomName,
                DoctorId = DoctorId
            };
            Symptoms.Add(symptom);
        }

        // public void CheckByName(string lastName) {
        //     if (!IsDoctorBooked) {
        //         IsDoctorBooked = true;
        //     } else {
        //         throw new Exception($"Doctor {lastName} is already booked!");
        //     }
        // }
           
        // public void PrescribeMedicine() {

        // }

        // public void CheckReports() {

        // }

        // public void PrescribeTests() {

        // }

        // public void DrewSalary() {
            
        // }

        public override string ToString() {
            string details = "";
            details += $"Id: {DoctorId}\n";
            details += $"Name: {Specialization} {FullName}\n";
            details += $"Phone number: {PhoneNumber}\n";
            details += $"Address: {Address}\n";
            details += $"Email: {Email}\n";
            return details + "\n";
        }

    }
}