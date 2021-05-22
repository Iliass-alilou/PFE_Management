using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFE_Management.Models
{
    public class Student 
    {
        [Key]
        public int ID { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Column("FirstName")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        /************/
        public bool etatAccount { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The Email address cannot be empty.")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [MaxLength(254, ErrorMessage = "The Email address cannot be longer than 254 characters.")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        //[Required(ErrorMessage = "The Password cannot be empty.")]
        [Display(Name = "Password")]
        [MaxLength(100, ErrorMessage = "The Password cannot be longer than 100 characters.")]
        public string Password { get; set; }


        [DataType(DataType.Password)]
        [Display(Name = "Password confirmation")]
        [MaxLength(100, ErrorMessage = "The Password cannot be longer than 100 characters.")]
        [Compare("Password", ErrorMessage = "The entered passwords do not match.")]
        public string PasswordConfirmation { get; set; }

        /************/
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Full Name")]
        public string FullName 
        { get
            {
                return LastName + " , " + FirstMidName;
            }
        }
        public ICollection<Enrollment> Enrollments { get; set; }



    }
}
