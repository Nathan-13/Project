using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HMSystemMvc.Models;

using HMSystem;
using HMSystem.Models;

namespace HMSystemMvc.Controllers
{
    public class PatientController : Controller
    {
        private HospitalSystem _hospital;

        public PatientController(HospitalSystem hospital)
        {
            _hospital = hospital;
        }

        public IActionResult Index()
        {
            List<Patient> patients = _hospital.GetAllPatients();
            return View(patients);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(Guid patientId) {
            var patient = _hospital.GetPatient(patientId);
            return View(patient);
        }

        public IActionResult Edit(Guid patientId) {
            // Get patient from hospital System
            var patient = _hospital.GetPatient(patientId);

            // Build the view model 
            var patientViewModel = new PatientViewModel() {
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                DateOfBirth = patient.DateOfBirth,
                PhoneNumber = patient.PhoneNumber,
                Address = patient.Address,
                Gender = patient.Gender,
                Illness = patient.Illness
            };
            // Send the view model
            ViewBag.IsEditing = true;
            return View("Form", patientViewModel);
        }

        public IActionResult Form() {
            ViewBag.IsEditing = false;
            return View();
        }

        [HttpPost]
        public IActionResult Create(PatientViewModel newPatient) {
            if(ModelState.IsValid) {
                var patientToCreate = new Patient(newPatient.Title, newPatient.FirstName, newPatient.LastName, newPatient.DateOfBirth, newPatient.PhoneNumber,
                newPatient.Illness, newPatient.Address, newPatient.DateAdmitted, newPatient.Gender) {
                    FirstName = newPatient.FirstName,
                    LastName = newPatient.LastName,
                    DateOfBirth = newPatient.DateOfBirth,
                    Gender = newPatient.Gender,
                    Illness = newPatient.Illness,
                    Address = newPatient.Address,
                    DateAdmitted = newPatient.DateAdmitted,
                    IsCheckedOut = false,
                    PatientId = Guid.NewGuid()
                };
                _hospital.AddNewPatient(patientToCreate);

                return RedirectToAction("Index");
            } else {
                return View("Form", newPatient);
            }
        }

        [HttpPost]
        public IActionResult Update(PatientViewModel updatedPatient) {
            if(ModelState.IsValid) {
                var patient = new Patient(updatedPatient.Title, updatedPatient.FirstName, updatedPatient.LastName, updatedPatient.DateOfBirth, 
                updatedPatient.PhoneNumber, updatedPatient.Address, updatedPatient.Illness, updatedPatient.DateAdmitted, updatedPatient.Gender) {
                    FirstName = updatedPatient.FirstName,
                    LastName = updatedPatient.LastName,
                    DateOfBirth = updatedPatient.DateOfBirth,
                    Gender = updatedPatient.Gender,
                    Address = updatedPatient.Address,
                    Illness = updatedPatient.Illness,
                    DateAdmitted = updatedPatient.DateAdmitted,
                    MedicationFees = updatedPatient.MedicationFees,
                    LabFees = updatedPatient.LabFees,
                    RehabFees = updatedPatient.RehabFees,
                    IsCheckedOut = false,
                    PatientId = Guid.NewGuid()
                };
                _hospital.UpdatePatient(patient);

                return RedirectToAction("Index");
            } else {
                return View("Form", updatedPatient);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
