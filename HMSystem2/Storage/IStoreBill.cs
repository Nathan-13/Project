using System;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public interface IStoreBill
    {
        void Create(Bill newBill);
        
        Bill GetByPatientId(Guid patientId);
    }
}