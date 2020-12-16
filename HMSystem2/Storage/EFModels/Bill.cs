using System;

namespace HMSystem.Storage.EFModels
{
    public class Bill
    {
        public Guid BillId { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public double TotalBill { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool IsBillsPaid { get; set; }
    }
}