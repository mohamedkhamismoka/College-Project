using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.VM
;
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department Name Is Required")]
        [MinLength(3, ErrorMessage = "Min Length Is 3")]
        [MaxLength(30, ErrorMessage = "Max Length Is 30")]
        public string Name { get; set; }


        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }

