using System;
using System.ComponentModel.DataAnnotations;

namespace HMSystemMvc.Models
{
    public class BillViewModel
    {
        [Required]
        public Guid BillId { get; set; }

        [Required]
        public Guid PatientId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public double TotalBill { get; set; }

        [Required]
        public DateTime DischargeDate { get; set; }
       
    }
}
