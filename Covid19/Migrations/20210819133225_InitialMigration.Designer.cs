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
    [Migration("20210819133225_InitialMigration")]
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

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Mail");

                    b.Property<int>("PhoneNumber");

                    b.Property<bool>("VaccinatedInBiH");

                    b.Property<int>("VaccineId");

                    b.HasKey("PatientId");

                    b.HasIndex("VaccineId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientId = 1,
                            FirstName = "firstName1",
                            LastName = "lastName1",
                            Mail = "sad@gadada.com",
                            PhoneNumber = 123456789,
                            VaccinatedInBiH = true,
                            VaccineId = 0
                        });
                });

            modelBuilder.Entity("Covid19.Models.Vaccine", b =>
                {
                    b.Property<int>("VaccineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstDate");

                    b.Property<string>("FirstSerialNumber");

                    b.Property<string>("Name");

                    b.Property<string>("SecondDate");

                    b.Property<string>("SecondSerialNumber");

                    b.HasKey("VaccineId");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            VaccineId = 1
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