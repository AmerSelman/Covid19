﻿// <auto-generated />
using Covid19.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Covid19.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210824121336_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Covid19.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstDateV")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstSerialNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasMaxLength(13);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SecondDateV")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SecondSerialNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("VaccinatedInBiH");

                    b.Property<int>("VaccineId");

                    b.HasKey("PatientId");

                    b.HasIndex("VaccineId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            FirstDateV = "10.02.2021.",
                            FirstName = "Omer",
                            FirstSerialNumber = "100551",
                            JMBG = "123456789",
                            LastName = "Hodžić",
                            Mail = "omer.h@gmail.com",
                            PhoneNumber = "069874123144",
                            SecondDateV = "03.03.2021",
                            SecondSerialNumber = "101221",
                            VaccinatedInBiH = true,
                            VaccineId = 1
                        },
                        new
                        {
                            PatientId = 2,
                            FirstDateV = "15.02.2021.",
                            FirstName = "Omera",
                            FirstSerialNumber = "100620",
                            JMBG = "234567891",
                            LastName = "Hadžić",
                            Mail = "omera.h@gmail.com",
                            PhoneNumber = "06987441321134",
                            SecondDateV = "08.03.2021",
                            SecondSerialNumber = "101451",
                            VaccinatedInBiH = true,
                            VaccineId = 2
                        },
                        new
                        {
                            PatientId = 3,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Elvis",
                            FirstSerialNumber = "100951",
                            JMBG = "345678912",
                            LastName = "Džeko",
                            Mail = "elvis.dž@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = false,
                            VaccineId = 3
                        },
                        new
                        {
                            PatientId = 4,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Elvina",
                            FirstSerialNumber = "100951",
                            JMBG = "456789123",
                            LastName = "Grgić",
                            Mail = "elvina.g@gmail.com",
                            PhoneNumber = "06187123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = true,
                            VaccineId = 3
                        },
                        new
                        {
                            PatientId = 5,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Katka",
                            FirstSerialNumber = "100951",
                            JMBG = "567891234",
                            LastName = "Burnić",
                            Mail = "katka.b@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = false,
                            VaccineId = 1
                        },
                        new
                        {
                            PatientId = 6,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Miralem",
                            FirstSerialNumber = "100951",
                            JMBG = "678912345",
                            LastName = "Pjanić",
                            Mail = "miralem.p@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = false,
                            VaccineId = 3
                        },
                        new
                        {
                            PatientId = 7,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Marko",
                            FirstSerialNumber = "100951",
                            JMBG = "789123456",
                            LastName = "Marić",
                            Mail = "marko.m@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = true,
                            VaccineId = 3
                        },
                        new
                        {
                            PatientId = 8,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Kasim",
                            FirstSerialNumber = "100951",
                            JMBG = "891234567",
                            LastName = "Rahić",
                            Mail = "kasim.l@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = false,
                            VaccineId = 3
                        },
                        new
                        {
                            PatientId = 9,
                            FirstDateV = "20.02.2021.",
                            FirstName = "Luka",
                            FirstSerialNumber = "100951",
                            JMBG = "912345678",
                            LastName = "Marković",
                            Mail = "elvis.dž@gmail.com",
                            PhoneNumber = "061874123474",
                            SecondDateV = "13.03.2021",
                            SecondSerialNumber = "101521",
                            VaccinatedInBiH = true,
                            VaccineId = 3
                        });
                });

            modelBuilder.Entity("Covid19.Models.Vaccine", b =>
                {
                    b.Property<int>("VaccineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VaccineName");

                    b.HasKey("VaccineId");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            VaccineId = 1,
                            VaccineName = "AstraZeneca"
                        },
                        new
                        {
                            VaccineId = 2,
                            VaccineName = "Pfizer-BioNTech"
                        },
                        new
                        {
                            VaccineId = 3,
                            VaccineName = "Moderna"
                        });
                });

            modelBuilder.Entity("Covid19.Models.Patient", b =>
                {
                    b.HasOne("Covid19.Models.Vaccine", "Vaccine")
                        .WithMany("patients")
                        .HasForeignKey("VaccineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
