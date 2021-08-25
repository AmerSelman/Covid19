using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Vaccine{
        public int VaccineId { get; set; }

        public string VaccineName { get; set; }

        public List<Patient> patients { get; set; }

    }
}
