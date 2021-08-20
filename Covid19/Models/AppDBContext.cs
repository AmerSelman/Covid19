using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Covid19.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Vaccine> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 1, Name = "AstraZeneca" });
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 2, Name = "Pfizer-BioNTech" });
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 3, Name = "Moderna" });

            //seed pies

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 1,
                FirstName = "Omer",
                LastName = "Hodžić",
                PhoneNumber = 069874123144,
                Mail = "omer.h@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 1
            });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 2,
                FirstName = "Omera",
                LastName = "Hadžić",
                PhoneNumber = 06987441321134,
                Mail = "omera.h@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 2
            });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 3,
                FirstName = "Elvis",
                LastName = "Džeko",
                PhoneNumber = 061874123474,
                Mail = "elvis.dž@gmail.com",
                VaccinatedInBiH = false,
                VaccineId = 3
            });
        }
    }
}
