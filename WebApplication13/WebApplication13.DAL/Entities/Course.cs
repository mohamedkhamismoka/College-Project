using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication13.DAL.Entities
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; } 

        public string Name { get; set; }    

        public int hours { get; set; }


        public IEnumerable<Student_course> Students_course { get; set; }
        public int? TeacherId { get; set; }

   
        public Teacher Teacher { get; set; }

    }
}
