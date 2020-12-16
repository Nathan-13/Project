using System;
using System.Collections.Generic;
using System.Linq;
using HMSystem.Models;

namespace HMSystem.Storage
{
    public class DoctorStorageList : IStoreDoctor
    {
        // Constructor
        public DoctorStorageList() {
            _doctorList = new List<Doctor>();
            // _doctorCapacity = 5;
        }

        // Data members for the class Doctor
        private List<Doctor> _doctorList;
        // int _doctorCapacity;
             
        // Methods
        public void Create(Doctor doctorToCreate) {
            _doctorList.Add(doctorToCreate);
        }

        // Get doctor by last name
        public List<Doctor> GetByLastName(string lastNameToSearch) {
            for(int i = 0; i < _doctorList.Count; i++) {
                Doctor nextDoctor = _doctorList[i];
                if (nextDoctor.LastName.ToLower() == lastNameToSearch.ToLower()) {
                    
                    return _doctorList;
                }
            }
            return null;
        }

        public Doctor GetById(Guid doctorId) {
            var doctor = _doctorList.Find(x => x.DoctorId == doctorId);

            if(doctor == null) {
                throw new Exception($"Doctor {doctorId} does not exist!!");
            }
            return doctor;
        }

        public void Update(Doctor doctorToUpdate) {
            var doctor = GetById(doctorToUpdate.DoctorId);
            doctor.FirstName = doctorToUpdate.FirstName;
            doctor.LastName = doctorToUpdate.LastName;
            doctor.Address = doctorToUpdate.Address;
            doctor.Email = doctorToUpdate.Email;
            doctor.PhoneNumber = doctorToUpdate.PhoneNumber;
            doctor.Specialization = doctorToUpdate.Specialization;
            doctor.Symptoms = doctorToUpdate.Symptoms;
            doctor.ImageUrl = doctorToUpdate.ImageUrl;
        }

        // Print doctor list   
        public List<Doctor> GetAll() {
            return _doctorList;
        }

    }
}