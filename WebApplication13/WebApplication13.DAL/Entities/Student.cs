using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication13.DAL.Entities
;
    public  class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int StudentId { get; set; }
        public string Name { get; set; }

    public virtual IEnumerable<Payment> payments { get; set; }
    public DateTime BirthDate { get; set; }

        public string address { get; set; }
        public virtual IEnumerable<Student_course> Students_courses { get; set; }
        public string phone { get; set; }

    public int? DepartmentId { get; set; }


    public virtual Department dept { get; set; }



    public string mail { get; set; }

        public string imgname { get; set; }

     

    
}
