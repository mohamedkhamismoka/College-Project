



using System.ComponentModel.DataAnnotations;

namespace WebApplication13.DAL.Entities
;
    public class Course
    {
        
        public int CourseId { get; set; }
    [StringLength(20)]
        public string Name { get; set; }    

        public int hours { get; set; }


        public  IEnumerable<Student_course> Students_course { get; set; }
   

        public int TeacherId { get; set; }

   
        public Teacher Teacher { get; set; }

    }

