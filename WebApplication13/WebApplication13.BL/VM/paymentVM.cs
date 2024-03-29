﻿

namespace WebApplication13.BL.VM
;
    public  class paymentVM
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Academic Year Is Required")]
        [Range(1,4,ErrorMessage ="Academic year must be from 1 to 4")]
        public int Academic_year { get; set; }
        [Range(1, long.MaxValue, ErrorMessage = "please select valid student")]
        public int StudentId { get; set; }
      
        public Student student { get; set; }

        [Required(ErrorMessage = "Term Is Required")]
        [Range(1, 2, ErrorMessage = "Term must be from 1 OR 4")]
        public int Term { get; set; }
        [Required(ErrorMessage = "Payed money Is Required")]
        [Range(1000,20000, ErrorMessage = "Payed Money range from 1K to 20K")]
        public int money { get; set; }
    }

