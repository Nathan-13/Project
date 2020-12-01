using System;
using System.ComponentModel.DataAnnotations;

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
        public string Specialty { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ImageUrl { get; set; }

    }
}
