using System;
using System.Collections.Generic;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public interface IStorePatient
    {
              
        void Create(Patient patientToCreate);
        int NumberOfPatients();
        Patient GetByPatientId(Guid patientId);
        void Update(Patient patientToUpdate);
        List<Patient> GetAll();
      
    }
}