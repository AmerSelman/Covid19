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
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 1, VaccineName = "AstraZeneca" });
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 2, VaccineName = "Pfizer-BioNTech" });
            modelBuilder.Entity<Vaccine>().HasData(new Vaccine { VaccineId = 3, VaccineName = "Moderna" });

            //seed pies

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 1,
                JMBG = "123456789",
                FirstName = "Omer",
                LastName = "Hodžić",
                PhoneNumber = "069874123144",
                Mail = "omer.h@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 1,
                FirstDateV = "10.02.2021.",
                SecondDateV = "03.03.2021",
                FirstSerialNumber = "100551",
                SecondSerialNumber = "101221"
            });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 2,
                JMBG = "234567891",
                FirstName = "Omera",
                LastName = "Hadžić",
                PhoneNumber = "06987441321134",
                Mail = "omera.h@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 2,
                FirstDateV = "15.02.2021.",
                SecondDateV = "08.03.2021",
                FirstSerialNumber = "100620",
                SecondSerialNumber = "101451"
            });

            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 3,
                JMBG = "345678912",
                FirstName = "Elvis",
                LastName = "Džeko",
                PhoneNumber = "061874123474",
                Mail = "elvis.dž@gmail.com",
                VaccinatedInBiH = false,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 4,
                JMBG = "456789123",
                FirstName = "Elvina",
                LastName = "Grgić",
                PhoneNumber = "06187123474",
                Mail = "elvina.g@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 5,
                JMBG = "567891234",
                FirstName = "Katka",
                LastName = "Burnić",
                PhoneNumber = "061874123474",
                Mail = "katka.b@gmail.com",
                VaccinatedInBiH = false,
                VaccineId = 1,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 6,
                JMBG = "678912345",
                FirstName = "Miralem",
                LastName = "Pjanić",
                PhoneNumber = "061874123474",
                Mail = "miralem.p@gmail.com",
                VaccinatedInBiH = false,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 7,
                JMBG = "789123456",
                FirstName = "Marko",
                LastName = "Marić",
                PhoneNumber = "061874123474",
                Mail = "marko.m@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 8,
                JMBG = "891234567",
                FirstName = "Kasim",
                LastName = "Rahić",
                PhoneNumber = "061874123474",
                Mail = "kasim.l@gmail.com",
                VaccinatedInBiH = false,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
            modelBuilder.Entity<Patient>().HasData(new Patient
            {
                PatientId = 9,
                JMBG = "912345678",
                FirstName = "Luka",
                LastName = "Marković",
                PhoneNumber = "061874123474",
                Mail = "elvis.dž@gmail.com",
                VaccinatedInBiH = true,
                VaccineId = 3,
                FirstDateV = "20.02.2021.",
                SecondDateV = "13.03.2021",
                FirstSerialNumber = "100951",
                SecondSerialNumber = "101521"
            });
        }
    }
}
