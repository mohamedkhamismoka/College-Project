

namespace WebApplication13.DAL.Entities
;
    public class Student_course
    { 

        public int StudentId { get; set; }
 
        public int CourseId { get; set; }
      
   
        public  Student student { get; set; }

    

        public  Course course { get; set; }

        public int degree { get; set; }

        public int Academic_year { get; set; }



        public int Term { get; set; }



    }

