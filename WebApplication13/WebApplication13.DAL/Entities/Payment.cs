using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication13.DAL.Entities
{
    public class Payment
    {[DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int Id { get; set; }


   
        public int Academic_year { get; set; }
 
        public int StudentId { get; set; }
   
        public Student student { get; set; }    
        public int Term { get; set; }

        public int money { get; set; }



    }
}
