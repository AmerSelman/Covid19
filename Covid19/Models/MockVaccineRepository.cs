using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class MockVaccineRepository: IVaccineRepository
    {
        public IEnumerable<Vaccine> AllVaccines =>
            new List<Vaccine>
            {
                new Vaccine{VaccineId = 1, VaccineName = "Astrazeneca"},
                new Vaccine{VaccineId = 2, VaccineName = "Pfizer-BioNTech"},
                new Vaccine{VaccineId = 3, VaccineName = "Moderna"}
            };

    }
}
