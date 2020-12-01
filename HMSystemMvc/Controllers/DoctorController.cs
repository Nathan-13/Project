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

        [HttpPost]
        public IActionResult Create(DoctorViewModel newDoctor) {

            if (ModelState.IsValid) {
                var doctorToCreate = new Doctor() {
                    FirstName = newDoctor.FirstName,
                    LastName = newDoctor.LastName,
                    Address = newDoctor.Address,
                    Specialty = newDoctor.Specialty,
                    Email = newDoctor.Email,
                    PhoneNumber = newDoctor.PhoneNumber,
                    ImageUrl = newDoctor.ImageUrl
                };
                _hospital.AddNewDoctor(doctorToCreate);

                RedirectToAction("Index");
            } else {
                return View("Form", newDoctor);
            }
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
