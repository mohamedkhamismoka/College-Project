


namespace WebApplication13.BL.Mapper
;
    public class DomainProfile :Profile
    {
        public DomainProfile()
        {
            CreateMap<Student, StudentVM>();
            CreateMap<StudentVM, Student>();
            CreateMap<Teacher, TeacherVM>();
            CreateMap<TeacherVM, Teacher>();
            CreateMap<Department, DepartmentVM>();
            CreateMap<DepartmentVM, Department>();
            CreateMap<Course, CourseVM>();
            CreateMap<CourseVM, Course>();
            CreateMap<Payment, paymentVM>();
            CreateMap<paymentVM, Payment>();
            CreateMap<StudentcourseVM, Student_course>();
            CreateMap<Student_course, StudentcourseVM>();
        }
    }

