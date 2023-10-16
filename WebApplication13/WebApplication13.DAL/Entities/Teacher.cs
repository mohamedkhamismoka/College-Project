


namespace WebApplication13.DAL.Entities
;
    public class Teacher
    {



        public int TeacherId { get; set; }
        public string Name { get; set; }

      
        public DateTime BirthDate { get; set; }

        public virtual IEnumerable<Course> courses { get; set; }

        public string address { get; set; }

        public string phone { get; set; }


       public string imgname { get; set; }

       public string Cvname { get; set; }


        public int DepartmentId { get; set; }

 
        public virtual Department dept { get; set; }

        public string mail { get; set; }
    }

