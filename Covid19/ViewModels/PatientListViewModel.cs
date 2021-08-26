using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Covid19.Models;

namespace Covid19.ViewModels
{
    public class PatientListViewModel
    {
        public IEnumerable<Patient> Patients { get; set; }

        public string VaccineName { get; set; }

        //public Patient JMBG { get; set; }

        //public Patient FirstName { get; set; }

        //public Patient LastName { get; set; }

        //public Patient PhoneNumber { get; set; }

        //public Patient Mail { get; set; }

        //public Patient FirstDateV { get; set; }

        //public Patient FirstSerialNumber { get; set; }

        //public Patient SecondDateV { get; set; }

        //public Patient SecondSerialNumber { get; set; }
    }
}
