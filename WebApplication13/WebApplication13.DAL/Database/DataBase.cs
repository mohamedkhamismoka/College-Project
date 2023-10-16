

namespace WebApplication13.DAL.Database
;
    public class DataBase:DbContext
    {

        public DataBase(DbContextOptions<DataBase> db):base(db)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_course>().HasKey(a => new {a.StudentId,a.CourseId});

   
    }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Teacher> Teachers { get; set; }

        public virtual DbSet<Payment> payments { get; set; }
        public virtual DbSet<Department> departments { get; set; }


        public virtual DbSet<Student_course> student_Courses { get; set; }  
        

    }

