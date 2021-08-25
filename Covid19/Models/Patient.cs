using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Covid19.Models
{
    public class Patient
    {
        
        private readonly AppDbContext _appDbContext;

        public Patient() { }
        private Patient(AppDbContext appDbContext){
            _appDbContext = appDbContext;
        }
        [BindNever]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "Unesite JMBG")]
        [Display(Name = "JMBG")]
        [StringLength(13)]
        public string JMBG { get; set; }

        [Required(ErrorMessage = "Unesite ime")]
        [Display(Name = "Ime")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Unesite prezime")]
        [Display(Name = "Prezime")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Unesite broj telefona")]
        [Display(Name = "Broj telefona")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        public string PhoneNumber { get; set; }


        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Unesite mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Unesite prvi datum")]
        [Display(Name = "Datum prve vakcinacije")]
        [DataType(DataType.Date)]
        [StringLength(20)]
        public string FirstDateV { get; set; }

        [Required(ErrorMessage = "Unesite drugi datum")]
        [Display(Name = "Datum druge vakcinacije")]
        [DataType(DataType.Date)]
        [StringLength(20)]
        public string SecondDateV { get; set; }

        [Required(ErrorMessage = "Unesite serijski broj prve vakcine")]
        [Display(Name = "Serijski broj vakcine")]
        [StringLength(50)]
        public string FirstSerialNumber { get; set; }


        [Required(ErrorMessage = "Unesite serijski broj druge vakcine")]
        [Display(Name = "Serijski broj vakcine")]
        [StringLength(50)]
        public string SecondSerialNumber { get; set; }


        [Display(Name = "Vakcinisan u BiH")]
        public bool VaccinatedInBiH { get; set; }

        public int VaccineId { get; set; }

        public Vaccine Vaccine { get; set; }

        
        public void AddPatient(Patient patient)
        {
        
            FirstName = patient.FirstName;
            LastName = patient.LastName;
            JMBG = patient.JMBG;
            PhoneNumber = patient.PhoneNumber;
            Mail = patient.Mail;
            FirstDateV = patient.FirstDateV;
            SecondDateV = patient.SecondDateV;
            FirstSerialNumber = patient.FirstSerialNumber;
            SecondSerialNumber = patient.SecondSerialNumber;
            VaccinatedInBiH = patient.VaccinatedInBiH;
            VaccineId = patient.VaccineId;

            _appDbContext.SaveChanges();
        }
    }
}
