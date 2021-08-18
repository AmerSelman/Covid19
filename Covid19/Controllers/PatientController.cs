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

        
    }
}
