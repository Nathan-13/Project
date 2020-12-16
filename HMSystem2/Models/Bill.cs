using System;

namespace HMSystem.Models
{
    public class Bill
    {
        public Bill(Patient patient) {
            BillId = Guid.NewGuid();
            Patient = patient;
            DischargeDate = DateTime.Now;
            TotalBill = patient.CalculateCharges;
            IsBillsPaid = false;
        }

        public Bill(Guid billId, Patient patient, Guid patientId, double totalBill, DateTime dischargeDate, bool isBillsPaid) {
            BillId = billId;
            Patient = patient;
            DischargeDate = dischargeDate;
            TotalBill = totalBill;
            IsBillsPaid = isBillsPaid;
        }
        
        // Data member
        public Guid BillId { get; set; }
        public Patient Patient { get; set; }
        public Guid PatientId { get; set; }
        public double TotalBill { get; set; }
        public DateTime DischargeDate { get; set; }
        public bool IsBillsPaid { get; set; }


        public void BillsPaid() {
            if(TotalBill == 0.00) {
                IsBillsPaid = true;
            } else {
                throw new Exception($"Hospital bill {BillId} is not paid!");
            }
        }
   
    }
}
      