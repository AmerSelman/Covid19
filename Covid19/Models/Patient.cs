using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long PhoneNumber { get; set; }

        public string Mail { get; set; }

        public string firstDateV { get; set; }
        public string secondDateV { get; set; }

        public bool VaccinatedInBiH { get; set; }

        public int VaccineId { get; set; }

        public Vaccine Vaccine { get; set; }

    }
}
