using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFE_Management.Models
{
    public class CourseAssignment
    {
        //les deux cle etrangeres doivent fonctionnent comme cle primaire composite
        //[ForeignKey]

        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
