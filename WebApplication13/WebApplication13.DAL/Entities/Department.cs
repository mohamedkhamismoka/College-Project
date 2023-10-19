

namespace WebApplication13.DAL.Entities
;
    public class Department
    {
       
        public int DepartmentId { get; set; }

        public string Name { get; set; }


    public  IEnumerable<Student> Students { get; set; }
    public  IEnumerable<Course> Courses { get; set; }
    public  IEnumerable<Teacher> Teachers { get; set; }
}

