using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class Vaccine{
        public int VaccineId { get; set; }

        public string Name { get; set; }

        public string FirstDate { get; set; }

        public string FirstSerialNumber { get; set; }

        public string SecondDate { get; set; }

        public string SecondSerialNumber { get; set; }

        public List<Patient> patients { get; set; }

    }
}
