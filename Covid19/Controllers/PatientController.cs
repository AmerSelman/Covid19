using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19.Models;
using Covid19.ViewModels;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc.Rendering;
using SelectPdf;
using Rotativa.AspNetCore;

namespace Covid19.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IVaccineRepository _vaccineRepository;
        public PatientController(IPatientRepository patientRepository, IVaccineRepository vaccineRepository){
            _patientRepository = patientRepository;
            _vaccineRepository = vaccineRepository;
        }



        public IActionResult List()
        {
            PatientListViewModel patientListViewModel = new PatientListViewModel();
            patientListViewModel.Patients = _patientRepository.AllPatients;


            return View(patientListViewModel);
        }

        public IActionResult PatientInfo(int id)
        {
            var patient = _patientRepository.GetPatientById(id);

            if(patient == null)
            {
                return NotFound();
            }
            //return View(patient);

            return new ViewAsPdf(patient);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Patient patient)
        {
            Patient newPatient = new Patient();
            newPatient.FirstName = patient.FirstName;
            newPatient.LastName = patient.LastName;
            newPatient.JMBG = patient.JMBG;
            newPatient.FirstDateV = patient.FirstDateV;
            newPatient.FirstSerialNumber = patient.FirstSerialNumber;
            newPatient.SecondDateV = patient.SecondDateV;
            newPatient.SecondSerialNumber = patient.SecondSerialNumber;
            newPatient.PhoneNumber = patient.PhoneNumber;
            newPatient.Mail = patient.Mail;


            if (ModelState.IsValid)
            {
                _patientRepository.AddPatient(newPatient);

                return RedirectToAction("AddPatientComplete");
            }
            return View(newPatient);
            //return View(patient);
        }

        public IActionResult AddPatientComplete()
        {
            ViewBag.AddPatientComplete = "Uspjesno";

            return View();
        }

        public RedirectToActionResult AddVaccinetedPatient(Patient patient)
        {
            _patientRepository.AddPatient(patient);

            return RedirectToAction("List");
        }
        
        public RedirectToActionResult RemovePatient(int patientId)
        {
            var selectedPatient = _patientRepository.AllPatients.FirstOrDefault(p => p.PatientId == patientId);

            return RedirectToAction("List");
        }

    }
}
