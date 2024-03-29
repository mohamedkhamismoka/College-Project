﻿
namespace WebApplication13.BL.VM
;
    public class TeacherVM
    {



        public int TeacherId { get; set; }
        [Required(ErrorMessage ="Teacher Name Is Required")]
        [MinLength(3,ErrorMessage ="Min Length Is 3")]
        [MaxLength(30, ErrorMessage = "Max Length Is 30")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Teacher BirthDate Is Required")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public IEnumerable<Course> courses { get; set; }
          [Required(ErrorMessage = "address Is Required")]
          public string address { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression("^01[0-2][0-9]{8}$", ErrorMessage = "Enter valid phone")]
        public string phone { get; set; }

        [Required(ErrorMessage = "CV is required")]
        public IFormFile cv { get; set; }
        [Required(ErrorMessage = "Image is required")]
        public IFormFile img { get; set; }
        public string imgname { get; set; }

        public string Cvname { get; set; }


        [DataType(DataType.EmailAddress, ErrorMessage = "Please Enter valid mail")]
        [Required(ErrorMessage = "Email is required")]

        public string mail { get; set; }

        public Department dept { get; set; }
        [Required(ErrorMessage = "Department is required")]

        [Range(1,long.MaxValue,ErrorMessage ="please select valid Department")]
        public int DepartmentId { get; set; }
    }

