using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication13.DAL.Entities
{
    public class Teacher
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int TeacherId { get; set; }
        public string Name { get; set; }

      
        public DateTime BirthDate { get; set; }

        public IEnumerable<Course> courses { get; set; }

        public string address { get; set; }

        public string phone { get; set; }


       public string imgname { get; set; }

       public string Cvname { get; set; }


        public int? DepartmentId { get; set; }

 
        public Department dept { get; set; }

        public string mail { get; set; }
    }
}
