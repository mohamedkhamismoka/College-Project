using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.DAL.Database
{
    public class DataBase:DbContext
    {

        public DataBase(DbContextOptions<DataBase> db):base(db)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_course>().HasKey(a => new {a.Std_Id,a.Crs_Id});






        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Payment> payments { get; set; }
        public DbSet<Department> departments { get; set; }


        public DbSet<Student_course> student_Courses { get; set; }  
        

    }
}
