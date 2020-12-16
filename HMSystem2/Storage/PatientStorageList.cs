using System;
using System.Collections.Generic;
using HMSystem.Models;
using System.Linq;

namespace HMSystem.Storage
{
    public class PatientStorageList : IStorePatient
    {
        // Constructor
        public PatientStorageList() {
            _patientList = new List<Patient>();
        }

        // Data members
        private List<Patient> _patientList;
        
        public void Create(Patient patientToCreate) {
            _patientList.Add(patientToCreate);
        }

        public int NumberOfPatients() {
            return _patientList.Count;
        }

        // public void Assign(string patientIllness) {
        //     var patient = _patientList.Find(x => x.)
        // }

        public Patient GetByPatientId(Guid patientId) {
            var patient = _patientList.Find(x => x.PatientId == patientId);

            if (patient == null) {
                throw new Exception($"Patient {patientId} does not exist!");
            }
            return patient;
        }

        public void Update(Patient patientToUpdate) {
            var patient = GetByPatientId(patientToUpdate.PatientId);
            patient.Title = patientToUpdate.Title;
            patient.FirstName = patientToUpdate.FirstName;
            patient.LastName = patientToUpdate.LastName;
            patient.DateOfBirth = patientToUpdate.DateOfBirth;
            patient.PhoneNumber = patientToUpdate.PhoneNumber;
            patient.Gender = patientToUpdate.Gender;
            patient.Address = patientToUpdate.Address;
            patient.Symptom = patientToUpdate.Symptom;
        }
        
        public List<Patient> GetAll() {
            return _patientList;
        }
        
    }
}