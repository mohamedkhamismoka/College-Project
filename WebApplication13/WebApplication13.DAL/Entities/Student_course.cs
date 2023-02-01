using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication13.DAL.Entities
{
    public class Student_course
    { 

        public int Std_Id { get; set; }
 
        public int Crs_Id { get; set; }
      
        public Student student { get; set; }
      
        public Course course { get; set; }

        public int degree { get; set; }

        public int Academic_year { get; set; }



        public int Term { get; set; }



    }
}
