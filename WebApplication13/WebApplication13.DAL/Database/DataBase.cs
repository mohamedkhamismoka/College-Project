

namespace WebApplication13.DAL.Database
;
    public class DataBase:DbContext
    {

        public DataBase(DbContextOptions<DataBase> db):base(db)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_course>().HasOne(a=>a.student).WithMany(a=>a.Students_courses).OnDelete(deleteBehavior:DeleteBehavior.NoAction);
        modelBuilder.Entity<Student_course>().HasKey(a => new { a.StudentId, a.CourseId });



    }

        public  DbSet<Student> Students { get; set; }
        public  DbSet<Course> Courses { get; set; }

        public  DbSet<Teacher> Teachers { get; set; }

        public  DbSet<Payment> payments { get; set; }
        public  DbSet<Department> departments { get; set; }


        public  DbSet<Student_course> student_Courses { get; set; }  
        

    }

