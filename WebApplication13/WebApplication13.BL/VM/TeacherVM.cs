using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace WebApplication13.BL.VM
{
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

        public Course Course { get; set; }

        public string address { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [RegularExpression("^01[0-2][0-9]{8}$", ErrorMessage = "Enter valid phone")]
        public string phone { get; set; }

        public IFormFile cv { get; set; }

        public IFormFile img { get; set; }
        public string imgname { get; set; }

        public string Cvname { get; set; }


        [DataType(DataType.EmailAddress, ErrorMessage = "Please Enter valid mail")]
        [Required(ErrorMessage = "Email is required")]

        public string mail { get; set; }

        public Department dept { get; set; }
        public int DepartmentId { get; set; }
    }
}
