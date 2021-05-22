using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFE_Management.Models
{
    public class DepartementChef
    {
        public int ID { get; set; }

        [EmailAddress]
        [Required]
        public String Email { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Column("FirstName")]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


       
       

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + "  " + FirstName;
            }
        }

    }
}
