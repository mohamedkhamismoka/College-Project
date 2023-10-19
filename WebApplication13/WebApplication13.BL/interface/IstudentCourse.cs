

namespace WebApplication13.BL
;
    public interface IstudentCourse
{
    public void create(Student_course std_crs);
    public void update(Student_course std_crs);

    public void delete(int student_id, int course_id);
 
    public IEnumerable<Student_course> GetStudent_Courses(int id);

        public IEnumerable<Student_course> getAll();
   public void deleteAllForstudent(int student_id);
   
    public IEnumerable<Student_course> GetStudent_degrees(int id);
}

