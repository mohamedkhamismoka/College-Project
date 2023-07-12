
namespace WebApplication13.BL.Reposatory
;
    public class StudentCourseRepo : IstudentCourse
    {
        private readonly DataBase db;

        public StudentCourseRepo(DataBase db)
        {
            this.db = db;
        }
        public void create(Student_course std_crs)
        {
            this.db.student_Courses.Add(std_crs);
            db.SaveChanges();
        }

        public void delete(int student_id,int course_id)
        {
           var data= this.db.student_Courses.Where(a=>a.StudentId==student_id &&a.CourseId==course_id).FirstOrDefault();
            this.db.student_Courses.Remove(data);
            db.SaveChanges();
        }

    public void deleteAllForstudent(int student_id)
    {
        var data = this.db.student_Courses.Where(a => a.StudentId == student_id);
        this.db.student_Courses.RemoveRange(data);
        db.SaveChanges();
    }

    public void deleteAllForCourse( int course_id)
    {
        var data = this.db.student_Courses.Where(a =>  a.CourseId == course_id);
        this.db.student_Courses.RemoveRange(data);
        db.SaveChanges();
    }
    public IEnumerable<Student_course> getAll()
        {
            return db.student_Courses.Select(a => a);
        }

        public IEnumerable<Student_course> GetStudent_Courses(int id)
        {
            var data= db.student_Courses.Where(a=>a.CourseId==id);
           
            return data;
        }

    public IEnumerable<Student_course> GetStudent_degrees(int id)
    {
        var data = db.student_Courses.Where(a => a.StudentId == id);

        return data;
    }


    public void update(Student_course std_crs)
        {
            db.Entry(std_crs).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }

