using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.VM
{
    public class StudentcourseVM
    {
        [Required(ErrorMessage = "Student is required")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Course is required")]
        public int CourseId { get; set; }

        public Student student { get; set; }



        public Course course { get; set; }

        [Required(ErrorMessage = "Degree is required"), Range(0, 100, ErrorMessage = "Degree must be between 0 and 100")]
        public int degree { get; set; }

        [Required(ErrorMessage = "Academic year is required"), Range(1, 4, ErrorMessage = "Academic year must be between 1 and 4")]
        public int Academic_year { get; set; }


        [Required(ErrorMessage = "Term is required"), Range(1, 2, ErrorMessage = "Term must be between 1 and 2")]
        public int Term { get; set; }
    }
}
