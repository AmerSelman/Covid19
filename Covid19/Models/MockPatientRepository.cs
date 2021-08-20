using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class MockPatientRepository: IPatientRepository
    {
        public IEnumerable<Patient> AllPatients =>
        new List<Patient>
        {
            new Patient{ PatientId = 1, FirstName = "firstName1", LastName = "LastName1", PhoneNumber = 123456789, Mail = "asdgsada", VaccinatedInBiH = true},
            new Patient{ PatientId = 2, FirstName = "firstName2", LastName = "LastName2", PhoneNumber = 234567891, Mail = "sdadaxsa", VaccinatedInBiH = false},
            new Patient{ PatientId = 3, FirstName = "firstName3", LastName = "LastName3", PhoneNumber = 345678912, Mail = "axcgsada", VaccinatedInBiH = true},
            new Patient{ PatientId = 4, FirstName = "firstName4", LastName = "LastName4", PhoneNumber = 456789123, Mail = "vbcgsada", VaccinatedInBiH = false},
            new Patient{ PatientId = 5, FirstName = "firstName5", LastName = "LastName5", PhoneNumber = 567891234, Mail = "nbvgsada", VaccinatedInBiH = false},
            new Patient{ PatientId = 6, FirstName = "firstName6", LastName = "LastName6", PhoneNumber = 678912345, Mail = "nbvgssda", VaccinatedInBiH = false},
            new Patient{ PatientId = 7, FirstName = "firstName7", LastName = "LastName7", PhoneNumber = 789123456, Mail = "adaretzu", VaccinatedInBiH = true},

        };


        public Patient GetPatientById(int patientId)
        {
            return AllPatients.FirstOrDefault(p => p.PatientId == patientId);
        }
    }
}
