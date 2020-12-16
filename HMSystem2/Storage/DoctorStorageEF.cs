using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public class DoctorStorageEF : IStoreDoctor
    {
        private HospitalContext _context;

        public DoctorStorageEF(HospitalContext context) {
            _context = context;
        }

        // Methods
        public void Create(Doctor doctorToCreate) {
            var doctorDb = ConvertToDb(doctorToCreate);
            _context.Doctors.Add(doctorDb);
            _context.SaveChanges();
        }

        public void Update(Doctor doctorToUpdate) {
            var doctorDb = ConvertToDb(doctorToUpdate);
            _context.Doctors.Add(doctorDb);
            _context.SaveChanges(); 
        }

        public Doctor GetById(Guid doctorId) {
            var doctorDb = _context.Doctors
                .AsNoTracking()
                .Include(x => x.Symptoms)
                .First(x => x.DoctorId == doctorId);
            
            return ConvertFromDb(doctorDb);
        }

        // Print doctor list   
        public List<Doctor> GetAll() {
            List<Doctor> results = new List<Doctor>();

            var doctorsFromDb = _context.Doctors.ToList();
            foreach (var doctorFromDb in doctorsFromDb) {
                var nextDoctor = ConvertFromDb(doctorFromDb);
                results.Add(nextDoctor);
            }
            return results;
        }

        public static EFModels.Doctor ConvertToDb(Doctor doctor) {
            return new EFModels.Doctor() {
                DoctorId = doctor.DoctorId,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Address = doctor.Address,
                PhoneNumber = doctor.PhoneNumber,
                Email = doctor.Email,
                Specialization = doctor.Specialization,
                ImageUrl = doctor.ImageUrl,
                NumberOfPatient = doctor.NumberOfPatient,
                IsDoctorBooked = doctor.IsDoctorBooked,
                Symptoms = doctor.Symptoms
                    .Select(x => ConvertToDb(x))
                    .ToList(),
            };
        }

        public static Doctor ConvertFromDb(EFModels.Doctor doctorFromDb) {
            return new Doctor(doctorFromDb.LastName, doctorFromDb.FirstName, doctorFromDb.Specialization, doctorFromDb.PhoneNumber, 
                            doctorFromDb.Address, doctorFromDb.Email, doctorFromDb.NumberOfPatient, doctorFromDb.ImageUrl) {
                LastName = doctorFromDb.LastName,
                FirstName = doctorFromDb.FirstName,
                Specialization = doctorFromDb.Specialization,
                PhoneNumber = doctorFromDb.PhoneNumber,
                Address = doctorFromDb.Address,
                Email = doctorFromDb.Email,
                NumberOfPatient = doctorFromDb.NumberOfPatient,
                ImageUrl = doctorFromDb.ImageUrl,
                DoctorId = doctorFromDb.DoctorId,
                IsDoctorBooked = doctorFromDb.IsDoctorBooked,
                Symptoms = doctorFromDb.Symptoms
                    .Select(x => ConvertFromDb(x))
                    .ToList(),
            };
        }

        public static EFModels.Symptom ConvertToDb(Symptom symptom) {
            return new EFModels.Symptom() {
                SymptomId = symptom.SymptomId,
                SymptomName = symptom.SymptomName,
                DoctorId = symptom.DoctorId,
            };
        }

        public static Symptom ConvertFromDb(EFModels.Symptom symptomDb) {
            return new Symptom() {
                SymptomId = symptomDb.SymptomId,
                SymptomName = symptomDb.SymptomName,
                DoctorId = symptomDb.DoctorId,
            };
        }

    }
}