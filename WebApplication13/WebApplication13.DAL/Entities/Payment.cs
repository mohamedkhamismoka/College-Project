

namespace WebApplication13.DAL.Entities
;
    public class Payment
    {[DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public int Id { get; set; }


   
        public int Academic_year { get; set; }
 
        public int StudentId { get; set; }
   
        public virtual Student student { get; set; }    
        public int Term { get; set; }

        public int money { get; set; }



    }

