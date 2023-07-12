

namespace WebApplication13.BL.VM
;
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        [Required(ErrorMessage = "Department Name Is Required")]
        [MinLength(2, ErrorMessage = "Min Length Is 2")]
        [MaxLength(30, ErrorMessage = "Max Length Is 30")]
        public string Name { get; set; }


        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Teacher> Teachers { get; set; }
    }

