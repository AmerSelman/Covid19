using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19.Models;
using Covid19.ViewModels;

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
            return View(patient);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Patient patient)
        {
            if (ModelState.IsValid)
            {
                _patientRepository.AddPatient(patient);

                return RedirectToAction("AddPatientComplete");
            }
            return View(patient);
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
