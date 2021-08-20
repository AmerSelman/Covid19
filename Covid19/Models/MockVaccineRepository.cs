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
                new Vaccine{VaccineId = 1, Name = "Astrazeneca",FirstSerialNumber = "123456", SecondSerialNumber = "2456481"}
            };

    }
}
