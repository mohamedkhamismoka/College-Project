


using System.ComponentModel.DataAnnotations;

namespace WebApplication13.DAL.Entities
;
    public class Teacher
    {



        public int TeacherId { get; set; }
    [StringLength(20)]
        public string Name { get; set; }

    [Column(TypeName = "Date")]
    public DateTime BirthDate { get; set; }

        public  IEnumerable<Course> courses { get; set; }

        public string address { get; set; }

        public string phone { get; set; }


       public string imgname { get; set; }

       public string Cvname { get; set; }


        public int DepartmentId { get; set; }

 
        public  Department dept { get; set; }

        public string mail { get; set; }
    }

