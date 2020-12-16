using System;
using System.Linq;
using System.Collections.Generic;

using HMSystem.Models;

namespace HMSystem.Storage
{
    public class BillStorageList : IStoreBill
    {
        private List<Bill> _billList;

        public BillStorageList() {
            _billList = new List<Bill>();
        }
        
        public void Create(Bill newBill) {
            _billList.Add(newBill);
        }
        
        
        public Bill GetByPatientId(Guid patientId) {
            var bill = _billList.Find(x => x.Patient.PatientId == patientId);

            if (bill == null) {
                throw new Exception ($"Bill does not exist for Paient {patientId}."); 
            }
            return bill;
        }
    }
}