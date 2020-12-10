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
    public class BillController : Controller
    {
        private HospitalSystem _hospital;

        public BillController(HospitalSystem hospital)
        {
            _hospital = hospital;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create (Guid patientId) {
            var patient = _hospital.GetPatient(patientId);

            var billViewModel = new BillViewModel() {
                PatientId = patientId,
                BillId = Guid.NewGuid(),
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                TotalBill = patient.CalculateCharges
            };
            return View(billViewModel);
        }

        [HttpPost]
        public IActionResult Create(BillViewModel newBill) {
            if (ModelState.IsValid) {
                _hospital.DischargePatient(newBill.PatientId);
                return RedirectToAction("Index");
            } else {
                return View(newBill);
            }
        }

        public IActionResult PayBill(Guid patientId) {
            _hospital.PayHospitalBill(patientId);
            return RedirectToAction("detials");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
