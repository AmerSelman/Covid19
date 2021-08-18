using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNumber { get; set; }

        public string Mail { get; set; }

        public bool VaccinatedInBiH { get; set; }

        public int VaccineId { get; set; }

        public Vaccine Vaccine { get; set; }

    }
}
