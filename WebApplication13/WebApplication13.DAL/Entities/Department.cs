

namespace WebApplication13.DAL.Entities
;
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        public string Name { get; set; }


    public virtual IEnumerable<Student> Students { get; set; }
    public virtual IEnumerable<Course> Courses { get; set; }
    public virtual IEnumerable<Teacher> Teachers { get; set; }
}

