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
                new Vaccine{VaccineId = 1, Name = "Astrazeneca", FirstDate = "12.03.2021.",FirstSerialNumber = "123456", SecondDate = "12.05.2021", SecondSerialNumber = "2456481"}
            };

    }
}
