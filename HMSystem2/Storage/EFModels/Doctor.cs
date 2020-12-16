using System;
using System.Collections.Generic;

namespace HMSystem.Storage.EFModels
{
    public class Doctor : Member
    {
        public Guid DoctorId { get; set;}
        public string Specialization { get; set;}
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDoctorBooked { get; set; }
        public List<Symptom> Symptoms { get; set; }
        public int NumberOfPatient { get; set; }
    }
}