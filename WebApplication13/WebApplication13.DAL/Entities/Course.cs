



namespace WebApplication13.DAL.Entities
;
    public class Course
    {
        
        public int CourseId { get; set; } 

        public string Name { get; set; }    

        public int hours { get; set; }


        public virtual IEnumerable<Student_course> Students_course { get; set; }
   

        public int? TeacherId { get; set; }

   
        public Teacher Teacher { get; set; }

    }

