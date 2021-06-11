using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PFE_Management.Models
{
    public class Stage
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string CIN { get; set; }
        [Required]
        public string CNE { get; set; }
        [Required, DataType(DataType.EmailAddress), EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Date)]
        [Display(Name = "Date de Naissance")]
        public DateTime DateNaissance { get; set; }

        //public string Filiere { get; set; }
        [Required]
        public string Annee { get; set; }
        //[Range(1, 10, ErrorMessage = "Notre numero ne doit pas depasser 10 chiffres")]
        public int Telephone { get; set; }
        [Required]
        [Display(Name = "Organisme Dacceuil")]
        public string OrganismeDacceuil { get; set; }
        [Display(Name = "Encadrant Externe")]
        public string EncadrantExterne { get; set; }

        [Required, DataType(DataType.EmailAddress), EmailAddress]
        [Display(Name = "Email encadrant")]
        public string EmailEncadrantExterne { get; set; }
        [Required]
        [Display(Name = "Telephone encadrant")]
        public int TelephoneEncadrantExterne { get; set; }
        [Required]
        [Display(Name = "Poste encadrant")]
        public string PosteEncadrantExterne { get; set; }
        [Required]
        [Display(Name = "Titre de stage")]
        public string TitreStage { get; set; }
        //[Required]
        [Display(Name = "Description de stage")]
        public string DescriptionStage { get; set; }
        [Required]
        [Display(Name = "Ville de stage")]
        public string VilleStage { get; set; }
        [Required]
        [Display(Name = "Pays de stage")]
        public string PaysStage { get; set; }

        [DefaultValue(false)]

        public bool EtatStage { get; set; }
        //[Required, DataType(DataType.Date)]
        [Display(Name = "Date debut de stage")]
        public DateTime DateDebutStage { get; set; }
        [Required, DataType(DataType.Date)]
        [Display(Name = "Date fin de stage")]
        public DateTime DateFinStage { get; set; }
        // cle etrangere departement 
        [Display(Name = "Filiere")]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        //cle etrangere Instructor
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        //cle etrangere Student
        public string StudentIDhashed { get; set; }


    }
}
