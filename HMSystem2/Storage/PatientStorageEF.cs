using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HMSystem.Models;
using System.Linq;

namespace HMSystem.Storage
{
    public class PatientStorageEF : IStorePatient
    {
        private HospitalContext _context;

        public PatientStorageEF(HospitalContext context) {
            _context = context;
        }

        public void Create(Patient patientToCreate) {
            var patientDb = ConvertToDb(patientToCreate);
            _context.Patients.Add(patientDb);
            _context.SaveChanges();
        }
        public void Update(Patient patientToUpdate) {
            var patientDb = ConvertToDb(patientToUpdate);
            _context.Patients.Update(patientDb);
            _context.SaveChanges();
        }

        public int NumberOfPatients() {
            var patientsFromDb = _context.Patients.Count();
            return patientsFromDb;
        }

        public Patient GetByPatientId(Guid patientId) {
            var patientDb = _context.Patients
                .AsNoTracking()
                .First(x => x.PatientId == patientId);
            var patient = ConvertFromDb(patientDb);
            return patient;
        }
        
        public List<Patient> GetAll() {
            List<Patient> results = new List<Patient>();

            var patientsFromDb = _context.Patients.ToList();
            foreach(var patientFromDb in patientsFromDb) {
                var nextPatient = ConvertFromDb(patientFromDb);
                results.Add(nextPatient);
            }
            return results;
        }

        public static EFModels.Patient ConvertToDb(Patient patient) {
            return new EFModels.Patient() {
                PatientId = patient.PatientId,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Address = patient.Address,
                PhoneNumber = patient.PhoneNumber,
                Title = patient.Title,
                DateOfBirth = patient.DateOfBirth,
                Gender = patient.Gender,
                Symptom = patient.Symptom,
                DateAdmitted = patient.DateAdmitted,
                BillPerDay = patient.BillPerDay,
                MedicationFees = patient.MedicationFees,
                LabFees = patient.LabFees,
                RehabFees = patient.RehabFees,
                RoomId = patient.RoomId,
                PatientDaysInHospital = patient.PatientDaysInHospital,
                IsCheckedOut = patient.IsCheckedOut,
            };
        }
        
        public static Patient ConvertFromDb(EFModels.Patient patientDb) {
            return new Patient(patientDb.Title, patientDb.FirstName, patientDb.LastName, patientDb.DateOfBirth, patientDb.PhoneNumber,
                    patientDb.Address, patientDb.Symptom, patientDb.DateAdmitted, patientDb.Gender) {
                PatientId = patientDb.PatientId,
                FirstName = patientDb.FirstName,
                LastName = patientDb.LastName,
                Address = patientDb.Address,
                PhoneNumber = patientDb.PhoneNumber,
                Title = patientDb.Title,
                DateOfBirth = patientDb.DateOfBirth,
                Gender = patientDb.Gender,
                Symptom = patientDb.Symptom,
                DateAdmitted = patientDb.DateAdmitted,
                BillPerDay = patientDb.BillPerDay,
                MedicationFees = patientDb.MedicationFees,
                LabFees = patientDb.LabFees,
                RehabFees = patientDb.RehabFees,
                RoomId = patientDb.RoomId,
                PatientDaysInHospital = patientDb.PatientDaysInHospital,
                IsCheckedOut = patientDb.IsCheckedOut,
            };
        }
    }
}