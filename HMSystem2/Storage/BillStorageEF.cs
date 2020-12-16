using System;
using System.Linq;
using System.Collections.Generic;
using HMSystem.Models;

using Microsoft.EntityFrameworkCore;

namespace HMSystem.Storage
{
    public class BillStorageEF : IStoreBill
    {
       private HospitalContext _context;

        public BillStorageEF(HospitalContext context) {
            _context = context;
        }
        
        public void Create(Bill newBill) {
            var billDb = ConvertToDb(newBill);
            _context.Bills.Add(billDb);
            _context.SaveChanges();
        }
        
        public Bill GetByPatientId(Guid patientId) {
           var billDb = _context.Bills
                .AsNoTracking()
                .Include(x => x.Patient)
                .First(x => x.PatientId == patientId);

            var bill = ConvertFromDb(billDb);
            return bill;
        }

        private static EFModels.Bill ConvertToDb(Bill bill) {
            return new EFModels.Bill() {
                BillId = bill.BillId,
                PatientId = bill.PatientId,
                IsBillsPaid = bill.IsBillsPaid,
                TotalBill = bill.TotalBill,
                DischargeDate = bill.DischargeDate,
            };
        }

        private static Bill ConvertFromDb(EFModels.Bill billDb) {
            return new Bill(
                billDb.BillId, 
                PatientStorageEF.ConvertFromDb(billDb.Patient), 
                billDb.PatientId, 
                billDb.TotalBill,
                billDb.DischargeDate,
                billDb.IsBillsPaid);   
        }
    }
}