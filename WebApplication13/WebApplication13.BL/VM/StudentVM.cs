using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL
{
    public class StudentVM
    {

        public int StudentId { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [MinLength(3,ErrorMessage ="Min Length  is 3 Characters")]
        [MaxLength(50, ErrorMessage = "Max Length  is 50 Characters")]
        public string Name { get; set; }

        IEnumerable<Payment> payments { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Please Enter valid Birtdate")]
        [Required(ErrorMessage = "Birtdate is required")]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Address is required")]
        [MinLength(3, ErrorMessage = "Min Length  is 3 Characters")]
        [MaxLength(50, ErrorMessage = "Max Length  is 50 Characters")]

        public string address { get; set; }
        public IEnumerable<Student_course> Students_courses { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression("^01[0-2][0-9]{8}$", ErrorMessage ="Enter valid phone")]
        public string phone { get; set; }


        [DataType(DataType.EmailAddress,ErrorMessage ="Please Enter valid mail")]
        [Required(ErrorMessage = "Email is required")]
        public string mail { get; set; }
        [Required(ErrorMessage = "image is required")]
        public IFormFile img { get; set; }
        public string imgname { get; set; }

        public Department dept { get; set; }

        [Range(1, long.MaxValue, ErrorMessage = "please select valid Department")]
        public int DepartmentId { get; set; }
    }
}
