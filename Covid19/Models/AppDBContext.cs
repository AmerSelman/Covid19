using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Covid19.Models
{
    public class AppDBContext : DbContext
    {
        AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 1 });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 1,
                FirstName = "firstName1",
                LastName = "lastName1",
                PhoneNumber = 123456789,
                Mail = "sad@gadada.com",
                VaccinatedInBiH = true,
                

            });

        }

    }
}
