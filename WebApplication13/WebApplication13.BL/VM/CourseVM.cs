using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.VM
;
    public class CourseVM
    {
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Course Name Is Required")]
        [MinLength(3, ErrorMessage = "Min Length Is 3")]
        [MaxLength(30, ErrorMessage = "Max Length Is 30")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Course Hours Is Required")]
        [Range(1,3,ErrorMessage ="Range must be between  1 and 3 hours")]

        public int hours { get; set; }


        public IEnumerable<Student_course> Students_course { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "please select valid Course Lecturer")]
        public int TeacherId { get; set; }

     
        public Teacher Teacher { get; set; }
    }

