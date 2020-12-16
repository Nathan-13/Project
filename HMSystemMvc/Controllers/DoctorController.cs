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
    public class DoctorController : Controller
    {
        private HospitalSystem _hospital;

        public DoctorController(HospitalSystem hospital)
        {
            _hospital = hospital;
        }

        public IActionResult Index()
        {
            List<Doctor> doctors = _hospital.GetAllDoctors();
            return View(doctors);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Details(Guid doctorId) {
            var doctor = _hospital.GetDoctor(doctorId);
            return View(doctor);
        }

        public IActionResult Edit(Guid doctorId) {
            //Get doctor from hosiptal system
            var doctor = _hospital.GetDoctor(doctorId);

            // Build the view Models
            var doctorViewModel = new DoctorViewModel() {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Address = doctor.Address,
                Specialization = doctor.Specialization,
                Email = doctor.Email,
                PhoneNumber = doctor.PhoneNumber,
                ImageUrl = doctor.ImageUrl,
            };

            // Send the view Model
            ViewBag.IsEditing = true;
            return View("Form", doctorViewModel);
        }

        public IActionResult Form() {
            // var bookToCreate = new BookViewModel() {
            //     Id = Guid.NewGuid()
            // };
            ViewBag.IsEditing = false;
            return View();
        }

        [HttpPost]
        public IActionResult Create(DoctorViewModel newDoctor) {

            if (ModelState.IsValid) {
                var doctorToCreate = new Doctor(newDoctor.FirstName, newDoctor.LastName, newDoctor.Specialization, 
                                                newDoctor.PhoneNumber, newDoctor.Address, newDoctor.Email, 0, newDoctor.ImageUrl) {
                    FirstName = newDoctor.FirstName,
                    LastName = newDoctor.LastName,
                    Address = newDoctor.Address,
                    Specialization = newDoctor.Specialization,
                    Email = newDoctor.Email,
                    PhoneNumber = newDoctor.PhoneNumber,
                    ImageUrl = newDoctor.ImageUrl,
                    DoctorId = Guid.NewGuid(),
                    Symptoms = new List<Symptom>(),
                    IsDoctorBooked = false
                };
                _hospital.AddNewDoctor(doctorToCreate);

                return RedirectToAction("Index");
            } else {
                return View("Form", newDoctor);
            }
        }

        [HttpPost]
        public IActionResult Update(DoctorViewModel updatedDoctor) {

            if (ModelState.IsValid) {
                var doctor = new Doctor(updatedDoctor.FirstName, updatedDoctor.LastName, updatedDoctor.Specialization, 
                                                updatedDoctor.PhoneNumber,updatedDoctor.Address, updatedDoctor.Email, 0, updatedDoctor.ImageUrl) {
                    FirstName = updatedDoctor.FirstName,
                    LastName = updatedDoctor.LastName,
                    Address = updatedDoctor.Address,
                    Specialization =updatedDoctor.Specialization,
                    Email = updatedDoctor.Email,
                    PhoneNumber = updatedDoctor.PhoneNumber,
                    ImageUrl = updatedDoctor.ImageUrl,
                    DoctorId = Guid.NewGuid(),
                    IsDoctorBooked = false
                };
                _hospital.UpdateDoctor(doctor);

                return RedirectToAction("Index");
            } else {
                return View("Form", updatedDoctor);
            }
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
