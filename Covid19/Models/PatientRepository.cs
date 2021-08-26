using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Models
{
    public class PatientRepository : IPatientRepository
    {
        private readonly AppDbContext _appDbContext;

        public PatientRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Patient> AllPatients
        {
            get
            {
                return _appDbContext.Patients.Include(v => v.Vaccine);
            }
        }

        public Patient GetPatientById(int patientId)
        {
            return _appDbContext.Patients.FirstOrDefault(p => p.PatientId == patientId);
        }

        public void EditPatient(Patient patient)
        {
            _appDbContext.Patients.Add(patient);

            _appDbContext.SaveChanges();
        }

        public void AddPatient(Patient patient)
        {
            _appDbContext.Patients.Add(patient);

            _appDbContext.SaveChanges();
        }

       public bool RemovePatient(int id)
        {
            Patient patient = _appDbContext.Patients.Find(id);
            

            _appDbContext.Patients.Remove(patient);

            _appDbContext.SaveChanges();

            return true;
        }
    }
}