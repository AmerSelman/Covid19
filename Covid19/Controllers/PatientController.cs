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

        public IActionResult Remove(int id)
        {

            _patientRepository.RemovePatient(id);

            return RedirectToAction("List");
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
            newPatient.VaccineId = patient.VaccineId;


            if (ModelState.IsValid)
            {
                _patientRepository.AddPatient(newPatient);

                return RedirectToAction("AddPatientComplete");
            }
            return View(newPatient);
            //return View(patient);
        }


        //public IActionResult Edit(Patient patient)
        //{
        //    var editPatient = _patientRepository.GetPatientById(patient.PatientId);



        //    editPatient.FirstName = patient.FirstName;
        //    editPatient.LastName = patient.LastName;
        //    editPatient.JMBG = patient.JMBG;
        //    editPatient.FirstDateV = patient.FirstDateV;
        //    editPatient.FirstSerialNumber = patient.FirstSerialNumber;
        //    editPatient.SecondDateV = patient.SecondDateV;
        //    editPatient.SecondSerialNumber = patient.SecondSerialNumber;
        //    editPatient.PhoneNumber = patient.PhoneNumber;
        //    editPatient.Mail = patient.Mail;
        //    editPatient.VaccineId = patient.VaccineId;
        //    if (ModelState.IsValid)
        //    {
        //        _patientRepository.EditPatient(editPatient);

        //        return RedirectToAction("AddPatientComplete");
        //    }
        //    return View(editPatient);

        //}

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

        
        
        
        
        //public IActionResult Edit(int id)
        //{
        //    var patient = _patientRepository.GetPatientById(id);

        //    return View(patient);
        //}
    }
}
