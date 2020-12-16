using System;
using System.ComponentModel.DataAnnotations;

namespace HMSystemMvc.Models
{
    public class PatientViewModel
    {
        public Guid? PatientId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public long PhoneNumber { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Symptom { get; set; }

        [Required]
        public DateTime DateAdmitted { get; set; }

        [Required]
        public char Gender {get; set;}
        
        [Required]
        public double MedicationFees { get; set; }

        [Required]
        public double LabFees { get; set; }

        [Required]
        public double RehabFees { get; set; }

    }
}
