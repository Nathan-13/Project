using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using HMSystem.Models;

namespace HMSystemMvc.Models
{
    public class DoctorViewModel
    {
        public Guid? DoctorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public long PhoneNumber { get; set; }
        
        [Required]
        public string Specialization { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        
        [Required]
        public List<Symptom> Symptoms { get; set; }

    }
}
